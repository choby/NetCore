using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerFooterSettings
    /// </summary>
    public partial class SchedulerFooterSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerFooterSettingsBuilder(SchedulerFooterSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerFooterSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
