using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesSettings
    /// </summary>
    public partial class SchedulerMessagesSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesSettingsBuilder(SchedulerMessagesSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
