using System;
using Inman.Infrastructure.Common;

namespace Inman.Infrastructure.Services
{
    public class AuthenticationResponse
    {
        public bool Success { get; set; }
    }

    public interface IAuthenticationService
    { 
        AuthenticationResponse Authenticate(RequestData requestData,
                                            bool throwException = false,
                                            Exception ex = null);
    }
}