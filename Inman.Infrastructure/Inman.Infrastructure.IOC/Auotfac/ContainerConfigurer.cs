using System;
using System.Linq;
using Inman.Infrastructure.Common;
using Autofac;

namespace Inman.Infrastructure.IOC
{
    public class ContainerConfigurer
    {
        public ContainerBuilder Configure(IEngine engine)//, EventBroker broker //to core modify
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            //to core modify
            //containerManager.AddComponentInstance<IEngine>(engine, "sys.engine");
            //containerManager.AddComponentInstance<ContainerConfigurer>(this, "sys.containerConfigurer");
            ////type finder
            //containerManager.AddComponent<ITypeFinder, WebAppTypeFinder>("sys.typeFinder");

            containerBuilder.RegisterInstance(engine).Keyed("sys.engine", typeof(IEngine)).As(typeof(IEngine)).PerLifeStyle(ComponentLifeStyle.Singleton);
           
            containerBuilder.RegisterType(typeof(WebAppTypeFinder)).As(typeof(ITypeFinder)).Keyed("sys.typeFinder", typeof(ITypeFinder)).PerLifeStyle(ComponentLifeStyle.Singleton);
            //register dependencies provided by other assemblies
            var typeFinder = new WebAppTypeFinder();

            //containerManager.UpdateContainer(x =>
            //{
                var drTypes = typeFinder.FindClassesOfType<IDependencyRegistrar>();
                var drInstances = drTypes.Select(drType => (IDependencyRegistrar) Activator.CreateInstance(drType)).ToList();
                //sort
                drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();
                foreach (var dependencyRegistrar in drInstances)
                    dependencyRegistrar.Register(containerBuilder, typeFinder);
            // });

            //event broker
            //containerManager.AddComponentInstance(broker); //to core modify
            containerBuilder.Build();
            return containerBuilder;
        }
    }
}
