using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace Inman.Infrastructure.Common.IOC
{
    public class Engine : AutofacServiceProvider, IEngine
    {
        #region Fields

       
        #endregion

        #region Ctor

        /// <summary>
        /// Creates an instance of the content engine using default settings and configuration.
        /// </summary>
        public Engine(IContainer container) : base(container)
        {
            
        }

        #endregion

        #region Utilities

        private void RunStartupTasks()
        {
            var typeFinder = this.GetService(typeof(ITypeFinder)) as ITypeFinder;
            if (typeFinder == null) return;

            var startUpTaskTypes = typeFinder.FindClassesOfType<IStartupTask>();
            var startUpTasks = new List<IStartupTask>();
            foreach (var startUpTaskType in startUpTaskTypes)
            { startUpTasks.Add((IStartupTask)Activator.CreateInstance(startUpTaskType)); }
            //sort
            startUpTasks = startUpTasks.AsQueryable().OrderBy(st => st.Order).ToList();
            foreach (var startUpTask in startUpTasks)
            { startUpTask.Exec(); }
        }
        

        #endregion


        #region Methods

        /// <summary>
        /// Initialize components and plugins in the nop environment.
        /// </summary>
        public void Initialize()
        {
            RunStartupTasks();
        }

       

        #endregion

        
    }
}
