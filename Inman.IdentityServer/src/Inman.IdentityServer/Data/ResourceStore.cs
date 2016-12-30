using IdentityServer4.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Inman.IdentityServer.Data.Domain;
using IdentityServer4.Models;
using Inman.IdentityServer.Exceptions;

namespace Inman.IdentityServer.Data
{
    public class ResourceStore : IResourceStore
    {
        private Resources _resources;
        #region
        IRepository<ApiResource> _apiRepository;
        IRepository<_IdentityResource> _identityRepository;
        public ResourceStore(IRepository<ApiResource> apiRepository,
            IRepository<_IdentityResource> identityRepository)
        {
            _apiRepository = apiRepository;
            _identityRepository = identityRepository;
        }
        #endregion

        public async Task<ApiResource> FindApiResourceAsync(string name)
        {
            var apiResouces = (await GetAllResources()).ApiResources;
            var apiResource = apiResouces.SingleOrDefault(t => t.Name == name);
            if (apiResource == null)
                throw new ApiNotFoundException(name);
            return apiResource;
        }

        public async Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            var apiResouces = (await GetAllResources()).ApiResources;
            return apiResouces.Where(t => t.Scopes.Any(d=> scopeNames.Contains(d.Name)) );
        }


        public async Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            var identityResources = (await GetAllResources()).IdentityResources;
            return identityResources.Where(t => scopeNames.Contains(t.Name));
        }

        public async Task<Resources> GetAllResources()
        {
            if (_resources != null)
                return _resources;

            var resources = new Resources();

            await findApiResources(resources);
            await findIdentityResources(resources);

            _resources = resources;

            return _resources;
        }

        private async  Task findApiResources(Resources resources)
        {
            //find all apiresources
            StringBuilder sb = new StringBuilder("SELECT * FROM ApiResources;");
            sb.Append("SELECT * FROM ApiScopes; ");
            sb.Append("SELECT * FROM ApiScopeClaims; ");
            sb.Append("SELECT * FROM ApiSecrets; ");
            sb.Append("SELECT * FROM ApiClaims; ");

            var gridReader = await _apiRepository.GetMultiResult(sb.ToString());
            var apiResources = gridReader.Read<_ApiResource>().ToList();
            var apiScopes = gridReader.Read<_ApiScope>().ToList();
            var apiScopeClaims = gridReader.Read<_ApiScopeClaim>().ToList();
            var apiSecrets = gridReader.Read<_ApiSecret>().ToList();
            var apiClaims = gridReader.Read<_ApiClaim>().ToList();

            foreach (var resource in apiResources)
            {
                resource.ApiSecrets = apiSecrets.Where(t => t.ApiResourceId == resource.Id).Cast<Secret>().ToList();
                resource.Scopes = apiScopes.Where(t => t.ApiResourceId == resource.Id).Select(t =>
                {
                    var scope = t as Scope;
                    scope.UserClaims = apiScopeClaims.Where(d => d.ApiScopeId == t.Id).Select(d => d.Type).ToList();
                    return scope;
                }).ToList();
                resource.UserClaims = apiClaims.Where(t => t.ApiResourceId == resource.Id).Select(t => t.Type).ToList();
            }

            resources.ApiResources = apiResources.Cast<ApiResource>().ToList();
        }

        private async Task findIdentityResources(Resources resources)
        {
            //identityresources
            var  sb = new StringBuilder("SELECT * FROM IdentityResources;");
            sb.Append("SELECT * FROM IdentityClaims;");

            var gridReader = await _identityRepository.GetMultiResult(sb.ToString());
            var idResources = gridReader.Read<_IdentityResource>().ToList();
            var idClaims = gridReader.Read<_IdentityClaim>().ToList();
            idResources.ForEach(res => res.UserClaims = idClaims.Where(d => d.IdentityResourceId == res.Id).Select(d => d.Type).ToList());

            resources.IdentityResources = idResources.Cast<IdentityResource>().ToList();
        }
    }
}
