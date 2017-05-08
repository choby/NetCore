using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorWeekdaysSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder(SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
