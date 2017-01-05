using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inman.IdentityServer.Exceptions
{
    public class ClientNotFoundException : Exception
    {
        public ClientNotFoundException(string clientId):
            base($"无效的Client标识:{clientId},[Not Found Client:{clientId}]")
        { }
    }
}
