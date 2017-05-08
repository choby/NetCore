using Kendo.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Kendo.Mvc
{
    public class KendoServices
    {
        public static IEnumerable<ServiceDescriptor> GetServices()
        {
            yield return ServiceDescriptor.Transient<IKendoHtmlGenerator, KendoHtmlGenerator>();
            yield return ServiceDescriptor.Transient<IUrlGenerator, UrlGenerator>();
        }
    }
}
