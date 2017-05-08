using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorFrequenciesSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder(SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
