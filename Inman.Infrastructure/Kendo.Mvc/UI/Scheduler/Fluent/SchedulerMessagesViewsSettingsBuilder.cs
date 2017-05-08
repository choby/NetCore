using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesViewsSettings
    /// </summary>
    public partial class SchedulerMessagesViewsSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesViewsSettingsBuilder(SchedulerMessagesViewsSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesViewsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
