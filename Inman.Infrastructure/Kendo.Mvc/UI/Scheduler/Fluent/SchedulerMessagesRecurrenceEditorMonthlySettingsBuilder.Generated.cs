using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorMonthlySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "Day " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Day</param>
        public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> Day(string value)
        {
            Container.Day = value;
            return this;
        }

        /// <summary>
        /// The text similar to " month(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Interval</param>
        public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> Interval(string value)
        {
            Container.Interval = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatEvery</param>
        public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> RepeatEvery(string value)
        {
            Container.RepeatEvery = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat on: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatOn</param>
        public SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T> RepeatOn(string value)
        {
            Container.RepeatOn = value;
            return this;
        }

    }
}
