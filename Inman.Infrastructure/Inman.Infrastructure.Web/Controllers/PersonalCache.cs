using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Inman.Infrastructure.Web
{
    public class PersonalCache
    {
        private readonly HttpContext HttpContext;
        private PersonalCache()
        {
            var httpContextAccessor = EngineContext.Current.GetService<IHttpContextAccessor>();
            if (httpContextAccessor != null && httpContextAccessor.HttpContext != null)
                HttpContext = httpContextAccessor.HttpContext;
        }

        private static readonly PersonalCache S_Instance = new PersonalCache();

        public object this[string key]
        {
            get { return HttpContext.Session.Get<object>(key); }
            set { HttpContext.Session.Set<object>(key,value); }
        }

        public void Remove(string key)
        {
            if (this[key] != null)
            { HttpContext.Session.Remove(key); }
        }

        public static PersonalCache Instance
        {
            get { return S_Instance; }
        }
    }
}
