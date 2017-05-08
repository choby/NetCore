using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorMonthlySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder(SchedulerMessagesRecurrenceEditorMonthlySettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorMonthlySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
