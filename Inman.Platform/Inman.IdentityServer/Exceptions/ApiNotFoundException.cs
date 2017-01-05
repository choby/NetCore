using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inman.IdentityServer.Exceptions
{
    public class ApiNotFoundException : Exception
    {
        public ApiNotFoundException(string name):
            base($"无效的API名称:{name},[Not Found API:{name}]")
        { }
    }
}
