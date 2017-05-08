using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceMessagesSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceMessagesSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "Do you want to delete only this event occurrence or the whole series?" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for DeleteRecurring</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteRecurring(string value)
        {
            Container.DeleteRecurring = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete current occurrence" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for DeleteWindowOccurrence</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteWindowOccurrence(string value)
        {
            Container.DeleteWindowOccurrence = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete the series" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for DeleteWindowSeries</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteWindowSeries(string value)
        {
            Container.DeleteWindowSeries = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete Recurring Item" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for DeleteWindowTitle</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> DeleteWindowTitle(string value)
        {
            Container.DeleteWindowTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Do you want to edit only this event occurrence or the whole series?" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for EditRecurring</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditRecurring(string value)
        {
            Container.EditRecurring = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Edit current occurrence" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for EditWindowOccurrence</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditWindowOccurrence(string value)
        {
            Container.EditWindowOccurrence = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Edit the series" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for EditWindowSeries</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditWindowSeries(string value)
        {
            Container.EditWindowSeries = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Edit Recurring Item" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for EditWindowTitle</param>
        public SchedulerMessagesRecurrenceMessagesSettingsBuilder<T> EditWindowTitle(string value)
        {
            Container.EditWindowTitle = value;
            return this;
        }

    }
}
