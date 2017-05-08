using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorEndSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder(SchedulerMessagesRecurrenceEditorEndSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorEndSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
