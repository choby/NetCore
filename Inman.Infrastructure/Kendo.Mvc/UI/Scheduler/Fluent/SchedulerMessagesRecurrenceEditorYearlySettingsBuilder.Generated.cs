using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorYearlySettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to " of " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Of</param>
        public SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T> Of(string value)
        {
            Container.Of = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat every: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatEvery</param>
        public SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T> RepeatEvery(string value)
        {
            Container.RepeatEvery = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat on: " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for RepeatOn</param>
        public SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T> RepeatOn(string value)
        {
            Container.RepeatOn = value;
            return this;
        }

        /// <summary>
        /// The text similar to " year(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Interval</param>
        public SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T> Interval(string value)
        {
            Container.Interval = value;
            return this;
        }

    }
}
