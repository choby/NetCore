using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Inman.Platform.ServiceStub;
using static Inman.Platform.ServiceStub.UserService;
using Inman.Platform.Data.Repository;
using Inman.Platform.Data.Domain;

namespace Inman.Platform.Service
{
    public class UserServiceImpl : UserServiceBase
    {
        IRepository<Customer> _repository;
        public UserServiceImpl(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        public override async Task<LoginResult> LoginValidate(LoginStuff request, ServerCallContext context)
        {
            //var password = request.Password.
            var loginResult = new LoginResult();
            var customer = await _repository.GetEntityAsync("SELECT * FROM Inman_Customer WHERE Username=@0 AND Password=@1", request.UserName, request.Password);
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
