using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorFrequenciesSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "Daily" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Daily</param>
        public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Daily(string value)
        {
            Container.Daily = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Monthly" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Monthly</param>
        public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Monthly(string value)
        {
            Container.Monthly = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Never" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Never</param>
        public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Never(string value)
        {
            Container.Never = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Weekly" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Weekly</param>
        public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Weekly(string value)
        {
            Container.Weekly = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Yearly" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Yearly</param>
        public SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T> Yearly(string value)
        {
            Container.Yearly = value;
            return this;
        }

    }
}
