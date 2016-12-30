using IdentityServer4.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inman.IdentityServer.Data.Domain;
using System.Security.Claims;
using System.Text;
using IdentityServer4.Models;
using Inman.IdentityServer.Exceptions;

namespace Inman.IdentityServer.Data
{
    public class ClientStore : IClientStore
    {
        IRepository<_Client> _clientRepository;
        public ClientStore(IRepository<_Client> clientRepository)
        {
            _clientRepository = clientRepository;
           
        }
        public async Task<Client> FindClientByIdAsync(string clientId)
        {
            var client = await _clientRepository.GetEntityAsync("SELECT * FROM Clients WHERE clientId=@0", clientId);

            if (client == null)
                throw new ClientNotFoundException(clientId);

            StringBuilder sb = new StringBuilder("SELECT Description,Expiration,Type,Value FROM ClientSecrets WHERE clientId=@0;");
            sb.Append("SELECT Scope FROM ClientScopes WHERE clientId=@0;");
            sb.Append("SELECT Type,Value FROM ClientClaims WHERE clientId=@0;");
            sb.Append("SELECT Origin FROM ClientCorsOrigins WHERE clientId=@0;");
            sb.Append("SELECT GrantType FROM ClientGrantTypes WHERE clientId=@0;");
            sb.Append("SELECT Provider FROM ClientIdPRestrictions WHERE clientId=@0;");
            sb.Append("SELECT PostLogoutRedirectUri FROM ClientPostLogoutRedirectUris WHERE clientId=@0;");
            sb.Append("SELECT RedirectUri FROM ClientRedirectUris WHERE clientId=@0;");

            //var id = _clientRepository.GetScalar<int>("SELECT Id FROM Clients WHERE clientId=@0", clientId);
            var gridReader = await _clientRepository.GetMultiResult(sb.ToString(), client.Id);

            client.ClientSecrets = gridReader.Read<_ClientSecret>().Cast<Secret>().ToList();
            client.AllowedScopes = gridReader.Read<_ClientScope>().Select(t => t.Scope).ToList();
            client.Claims = gridReader.Read<_ClientClaim>().Select(t => new Claim(t.Type, t.Value)).ToList() ;
            client.AllowedCorsOrigins = gridReader.Read<_ClientCorsOrigin>().Select(t => t.Origin).ToList();
            client.AllowedGrantTypes = gridReader.Read<_ClientGrantType>().Select(t => t.GrantType).ToList();
            client.IdentityProviderRestrictions = gridReader.Read<_ClientIdPRestriction>().Select(t => t.Provider).ToList();
            client.PostLogoutRedirectUris = gridReader.Read<_ClientPostLogoutRedirectUri>().Select(t => t.PostLogoutRedirectUri).ToList();
            client.RedirectUris = gridReader.Read<_ClientRedirectUri>().Select(t => t.RedirectUri).ToList();

            return client;
        }

    }
}
