using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorWeeklySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to " week(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Interval</param>
        public SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T> Interval(string value)
        {
            Container.Interval = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatEvery</param>
        public SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T> RepeatEvery(string value)
        {
            Container.RepeatEvery = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat on: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatOn</param>
        public SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T> RepeatOn(string value)
        {
            Container.RepeatOn = value;
            return this;
        }

    }
}
