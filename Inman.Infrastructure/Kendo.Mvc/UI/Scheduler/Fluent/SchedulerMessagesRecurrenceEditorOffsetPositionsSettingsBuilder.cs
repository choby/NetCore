using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorOffsetPositionsSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder(SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
