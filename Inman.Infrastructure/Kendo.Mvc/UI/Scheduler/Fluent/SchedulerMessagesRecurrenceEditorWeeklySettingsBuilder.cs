using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorWeeklySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder(SchedulerMessagesRecurrenceEditorWeeklySettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorWeeklySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
