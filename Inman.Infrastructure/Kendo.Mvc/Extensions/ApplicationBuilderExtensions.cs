using Kendo.Mvc.Infrastructure.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// UseKendo extension method for IApplicationBuilder
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Configures the Kendo UI services.
        /// </summary>
        public static void UseKendo(this IApplicationBuilder app, IHostingEnvironment env)
        {
            ClassFactory.Create(env);
        }
    }
}