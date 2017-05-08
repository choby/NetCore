using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesViewsSettings
    /// </summary>
    public partial class SchedulerMessagesViewsSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "Day" displayed as scheduler "day" view title.
        /// </summary>
        /// <param name="value">The value for Day</param>
        public SchedulerMessagesViewsSettingsBuilder<T> Day(string value)
        {
            Container.Day = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Week" displayed as scheduler "week" view title.
        /// </summary>
        /// <param name="value">The value for Week</param>
        public SchedulerMessagesViewsSettingsBuilder<T> Week(string value)
        {
            Container.Week = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Month" displayed as scheduler "month" view title.
        /// </summary>
        /// <param name="value">The value for Month</param>
        public SchedulerMessagesViewsSettingsBuilder<T> Month(string value)
        {
            Container.Month = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Agenda" displayed as scheduler "agenda" view title.
        /// </summary>
        /// <param name="value">The value for Agenda</param>
        public SchedulerMessagesViewsSettingsBuilder<T> Agenda(string value)
        {
            Container.Agenda = value;
            return this;
        }

    }
}
