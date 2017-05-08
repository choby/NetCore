using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceMessagesSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceMessagesSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder(SchedulerMessagesRecurrenceMessagesSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceMessagesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
