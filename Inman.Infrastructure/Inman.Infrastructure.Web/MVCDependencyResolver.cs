using System;
using System.Collections.Generic;
using Autofac;
using Inman.Infrastructure.Common;
using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Http;

namespace Inman.Infrastructure.Web
{
    public class MVCDependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 0;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterType<WebHelper>().As<IWebHelper>().InstancePerLifetimeScope();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().InstancePerLifetimeScope();
            builder.Register(c =>
            {
                var httpContextAccessor = c.Resolve<IHttpContextAccessor>();
                return httpContextAccessor.HttpContext;
            }).As<HttpContext>().InstancePerLifetimeScope();
        }
    }
}
