using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Inman.Infrastructure.Web
{
    public class HttpHelper
    {
        public static HttpContext HttpContext
        {
            get
            {
                var httpContextAccessor = EngineContext.Current.GetService<IHttpContextAccessor>();
                return httpContextAccessor.HttpContext;
            }
        }
    }
}
