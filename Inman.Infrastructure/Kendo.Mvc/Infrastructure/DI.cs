using Kendo.Mvc.Infrastructure.Implementation;
using Kendo.Mvc.UI.Html;
using Microsoft.AspNetCore.Http;

namespace Kendo.Mvc.Infrastructure
{
    public static class DI
    {
        public static IDependencyInjectionContainer Current { get; set; }
        
        static DI()
        {
            Current = new DependencyInjectionContainer();
            
            FileDependencyBootstrapper.Setup();
        }
    }
}
