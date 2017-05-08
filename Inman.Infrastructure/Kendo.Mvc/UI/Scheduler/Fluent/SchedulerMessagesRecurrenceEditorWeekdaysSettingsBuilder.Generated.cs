using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorWeekdaysSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "day" displayed in the repeat by section of the monthly recurrence pattern.
        /// </summary>
        /// <param name="value">The value for Day</param>
        public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> Day(string value)
        {
            Container.Day = value;
            return this;
        }

        /// <summary>
        /// The text similar to "weekday" displayed in the repeat by section of the monthly recurrence pattern.
        /// </summary>
        /// <param name="value">The value for Weekday</param>
        public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> Weekday(string value)
        {
            Container.Weekday = value;
            return this;
        }

        /// <summary>
        /// The text similar to "weekend" displayed in the repeat by section of the monthly recurrence pattern.
        /// </summary>
        /// <param name="value">The value for Weekend</param>
        public SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T> Weekend(string value)
        {
            Container.Weekend = value;
            return this;
        }

    }
}
