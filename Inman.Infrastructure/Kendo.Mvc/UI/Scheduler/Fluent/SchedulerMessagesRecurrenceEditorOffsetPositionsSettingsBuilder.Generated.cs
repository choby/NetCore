using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorOffsetPositionsSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "first" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for First</param>
        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> First(string value)
        {
            Container.First = value;
            return this;
        }

        /// <summary>
        /// The text similar to "second" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Second</param>
        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Second(string value)
        {
            Container.Second = value;
            return this;
        }

        /// <summary>
        /// The text similar to "third" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Third</param>
        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Third(string value)
        {
            Container.Third = value;
            return this;
        }

        /// <summary>
        /// The text similar to "fourth" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Fourth</param>
        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Fourth(string value)
        {
            Container.Fourth = value;
            return this;
        }

        /// <summary>
        /// The text similar to "last" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Last</param>
        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T> Last(string value)
        {
            Container.Last = value;
            return this;
        }

    }
}
