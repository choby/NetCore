using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesEditableSettings
    /// </summary>
    public partial class SchedulerMessagesEditableSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesEditableSettingsBuilder(SchedulerMessagesEditableSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesEditableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
