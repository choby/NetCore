using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorDailySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to " day(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Interval</param>
        public SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T> Interval(string value)
        {
            Container.Interval = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatEvery</param>
        public SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T> RepeatEvery(string value)
        {
            Container.RepeatEvery = value;
            return this;
        }

    }
}
