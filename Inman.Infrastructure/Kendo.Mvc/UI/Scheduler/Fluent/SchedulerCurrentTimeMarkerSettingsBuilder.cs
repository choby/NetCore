using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerCurrentTimeMarkerSettings
    /// </summary>
    public partial class SchedulerCurrentTimeMarkerSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerCurrentTimeMarkerSettingsBuilder(SchedulerCurrentTimeMarkerSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerCurrentTimeMarkerSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
