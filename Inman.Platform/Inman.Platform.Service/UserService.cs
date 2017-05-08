using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Inman.Platform.ServiceStub;
using static Inman.Platform.ServiceStub.UserService;
using Inman.Platform.Data.Entities;
using Inman.Platform.ServiceStub.Data;
using Inman.Infrastructure.Data.Repositories;
using Inman.Infrastructure.Data.DapperExtensions;
using Inman.Infrastructure.Data;

namespace Inman.Platform.Service
{
    public class UserServiceImpl : UserServiceBase
    {
        IDapperRepository<Inman_Customer,int> _repository;
        public UserServiceImpl(IDapperRepository<Inman_Customer,int> repository)
        {
            _repository = repository;
        }
        public override async Task<LoginResult> LoginValidate(LoginStuff request, ServerCallContext context)
        {

               //var password = request.Password.
               var loginResult = new LoginResult();

            var fpUserName = PredicateHelper.BuildFieldPredicate<Inman_Customer>("UserName", request.UserName, Operator.Eq);
            var fpPassword = PredicateHelper.BuildFieldPredicate<Inman_Customer>("Password", request.Password, Operator.Eq);
            var pg = PredicateHelper.BuildPredicateGroup(GroupOperator.And,fpUserName, fpPassword);

            var customer = await _repository.GetAsync(pg);
            if (customer == null)
                loginResult.Success = false;
            else
            {
                loginResult.Success = true;
                loginResult.User = new User { Id = customer.Id, OpenId = customer.CustomerGuid.ToString(), UserName = customer.Username };
            }
            return loginResult;
        }
    }
}
