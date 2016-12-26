using System;
using System.Diagnostics;
using Autofac;
using System.Linq;

namespace Inman.Infrastructure.Common.IOC
{
    /// <summary>
    /// Provides access to the singleton instance of the Nop engine.
    /// </summary>
    public class EngineContext
    {
        #region Initialization Methods
        /// <summary>Initializes a static instance of the Nop factory.</summary>
        /// <param name="forceRecreate">Creates a new factory instance even though the factory has been previously initialized.</param>
        //[MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngine Initialize(bool forceRecreate)
        {
            if (Singleton<IEngine>.Instance == null || forceRecreate)
            {
                
                Debug.WriteLine("Constructing engine " + DateTime.Now);
                Singleton<IEngine>.Instance = CreateEngineInstance();
                Debug.WriteLine("Initializing engine " + DateTime.Now);
                Singleton<IEngine>.Instance.Initialize();
            }
            return Singleton<IEngine>.Instance;
        }

        /// <summary>Sets the static engine instance to the supplied engine. Use this method to supply your own engine implementation.</summary>
        /// <param name="engine">The engine to use.</param>
        /// <remarks>Only use this method if you know what you're doing.</remarks>
        public static void Replace(IEngine engine)
        {
            Singleton<IEngine>.Instance = engine;
        }

        /// <summary>
        /// Creates a factory instance and adds a http application injecting facility.
        /// </summary>
        /// <returns>A new factory</returns>
        public static IEngine CreateEngineInstance()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            var typeFinder = new WebAppTypeFinder();
            containerBuilder.Register<ITypeFinder>(context=> typeFinder).Keyed("sys.typeFinder", typeof(ITypeFinder)).SingleInstance();
           
            var drTypes = typeFinder.FindClassesOfType<IDependencyRegistrar>();
            var drInstances = drTypes.Select(drType => (IDependencyRegistrar)Activator.CreateInstance(drType)).ToList();
            //sort
            drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();
            foreach (var dependencyRegistrar in drInstances)
                dependencyRegistrar.Register(containerBuilder, typeFinder);
         
            var container = containerBuilder.Build();

            return new Engine(container);
        }

        #endregion

        /// <summary>Gets the singleton Nop engine used to access Nop services.</summary>
        public static IEngine Current
        {
            get
            {
                if (Singleton<IEngine>.Instance == null)
                {
                    Initialize(false);
                }
                return Singleton<IEngine>.Instance;
            }
        }
    }
}
