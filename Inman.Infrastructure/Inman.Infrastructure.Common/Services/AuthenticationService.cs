using System;
using System.Security.Authentication;
using Inman.Infrastructure.Common;

namespace Inman.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResponse Authenticate(RequestData requestData,
                                                   bool throwException = false,
                                                   Exception ex = null)
        {
            if (!"abceadcf15693!gfdsevdstea1fdadsreg158763458".Equals((requestData.SessionKey ?? string.Empty).Trim())
                || !"147258369".Equals((requestData.AppKey ?? string.Empty).Trim()))
            {
                if (throwException)
                {
                    if (ex == null)
                    { ex = new AuthenticationException("认证失败"); }

                    throw ex;
                }
                else
                {
                    return new AuthenticationResponse()
                        {
                            Success = false
                        };
                }
            }
            else
            {
                return new AuthenticationResponse()
                {
                    Success = true
                };
            }
        }
    }
}