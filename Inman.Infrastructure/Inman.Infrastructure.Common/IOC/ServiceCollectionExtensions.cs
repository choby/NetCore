using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Infrastructure.Common.IOC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceProvider AddAutofac(this IServiceCollection services)
        {
            EngineContext.Populate(services);
            EngineContext.Initialize(false);
            return EngineContext.Current;
        }
    }
}
