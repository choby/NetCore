using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorDailySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorDailySettingsBuilder(SchedulerMessagesRecurrenceEditorDailySettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorDailySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
