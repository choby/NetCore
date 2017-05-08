using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorSettingsBuilder(SchedulerMessagesRecurrenceEditorSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
