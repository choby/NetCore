using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorYearlySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorYearlySettingsBuilder(SchedulerMessagesRecurrenceEditorYearlySettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorYearlySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
