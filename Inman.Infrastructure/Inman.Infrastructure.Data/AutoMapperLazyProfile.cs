using Inman.Infrastructure.Common;
using Inman.Infrastructure.Common.IOC;
using System;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;

namespace Inman.Infrastructure.Data
{
    public partial class AutoMapperLazyProfile
    {
        public void Configure()
        {

            ITypeFinder typeFinder = EngineContext.Current.GetService<ITypeFinder>();
            var types = typeFinder.FindClassesOfType<IAutoMapperConfigure>();
            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                if (instance == null)
                    continue;
                ThreadPool.QueueUserWorkItem(r =>
                {
                    ((IAutoMapperConfigure)instance).Configure();
                });

            }
        }
    }
}
