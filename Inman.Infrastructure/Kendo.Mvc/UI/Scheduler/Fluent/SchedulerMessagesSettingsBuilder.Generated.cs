using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesSettings
    /// </summary>
    public partial class SchedulerMessagesSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "all day" displayed in day,week and agenda views.
        /// </summary>
        /// <param name="value">The value for AllDay</param>
        public SchedulerMessagesSettingsBuilder<T> AllDay(string value)
        {
            Container.AllDay = value;
            return this;
        }

        /// <summary>
        /// Specifies the format string used to populate the aria-label attribute value of the selected event element.The arguments which can be used in the format string are:
        /// </summary>
        /// <param name="value">The value for AriaEventLabel</param>
        public SchedulerMessagesSettingsBuilder<T> AriaEventLabel(string value)
        {
            Container.AriaEventLabel = value;
            return this;
        }

        /// <summary>
        /// Specifies the format string used to populate the aria-label attribute value of the selected slot element.The arguments which can be used in the format string are:
        /// </summary>
        /// <param name="value">The value for AriaSlotLabel</param>
        public SchedulerMessagesSettingsBuilder<T> AriaSlotLabel(string value)
        {
            Container.AriaSlotLabel = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Cancel" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Cancel</param>
        public SchedulerMessagesSettingsBuilder<T> Cancel(string value)
        {
            Container.Cancel = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Date" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Date</param>
        public SchedulerMessagesSettingsBuilder<T> Date(string value)
        {
            Container.Date = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete event" displayed as title of the scheduler delete event window.
        /// </summary>
        /// <param name="value">The value for DeleteWindowTitle</param>
        public SchedulerMessagesSettingsBuilder<T> DeleteWindowTitle(string value)
        {
            Container.DeleteWindowTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Destroy</param>
        public SchedulerMessagesSettingsBuilder<T> Destroy(string value)
        {
            Container.Destroy = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Event" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Event</param>
        public SchedulerMessagesSettingsBuilder<T> Event(string value)
        {
            Container.Event = value;
            return this;
        }

        /// <summary>
        /// The text similar to "All events" displayed in timeline views when there is no vertical grouping.
        /// </summary>
        /// <param name="value">The value for DefaultRowText</param>
        public SchedulerMessagesSettingsBuilder<T> DefaultRowText(string value)
        {
            Container.DefaultRowText = value;
            return this;
        }

        /// <summary>
        /// The text displayed by the PDF export button.
        /// </summary>
        /// <param name="value">The value for Pdf</param>
        public SchedulerMessagesSettingsBuilder<T> Pdf(string value)
        {
            Container.Pdf = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Save" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Save</param>
        public SchedulerMessagesSettingsBuilder<T> Save(string value)
        {
            Container.Save = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Show full day" used in scheduler "showFullDay" button.
        /// </summary>
        /// <param name="value">The value for ShowFullDay</param>
        public SchedulerMessagesSettingsBuilder<T> ShowFullDay(string value)
        {
            Container.ShowFullDay = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Show business hours" used in scheduler "showWorkDay" button.
        /// </summary>
        /// <param name="value">The value for ShowWorkDay</param>
        public SchedulerMessagesSettingsBuilder<T> ShowWorkDay(string value)
        {
            Container.ShowWorkDay = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Time" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Time</param>
        public SchedulerMessagesSettingsBuilder<T> Time(string value)
        {
            Container.Time = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Today" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Today</param>
        public SchedulerMessagesSettingsBuilder<T> Today(string value)
        {
            Container.Today = value;
            return this;
        }

        /// <summary>
        /// The configuration of the scheduler editable messages. Use this option to customize or localize the scheduler editable messages.
        /// </summary>
        /// <param name="configurator">The configurator for the editable setting.</param>
        public SchedulerMessagesSettingsBuilder<T> Editable(Action<SchedulerMessagesEditableSettingsBuilder<T>> configurator)
        {

            Container.Editable.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesEditableSettingsBuilder<T>(Container.Editable));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler editor messages. Use this option to customize or localize the scheduler editor messages.
        /// </summary>
        /// <param name="configurator">The configurator for the editor setting.</param>
        public SchedulerMessagesSettingsBuilder<T> Editor(Action<SchedulerMessagesEditorSettingsBuilder<T>> configurator)
        {

            Container.Editor.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesEditorSettingsBuilder<T>(Container.Editor));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor messages. Use this option to customize or localize the scheduler recurrence editor messages.
        /// </summary>
        /// <param name="configurator">The configurator for the recurrenceeditor setting.</param>
        public SchedulerMessagesSettingsBuilder<T> RecurrenceEditor(Action<SchedulerMessagesRecurrenceEditorSettingsBuilder<T>> configurator)
        {

            Container.RecurrenceEditor.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorSettingsBuilder<T>(Container.RecurrenceEditor));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence messages. Use this option to customize or localize the scheduler recurrence messages.
        /// </summary>
        /// <param name="configurator">The configurator for the recurrencemessages setting.</param>
        public SchedulerMessagesSettingsBuilder<T> RecurrenceMessages(Action<SchedulerMessagesRecurrenceMessagesSettingsBuilder<T>> configurator)
        {

            Container.RecurrenceMessages.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceMessagesSettingsBuilder<T>(Container.RecurrenceMessages));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler views messages. Use this option to customize or localize the scheduler views messages.
        /// </summary>
        /// <param name="configurator">The configurator for the views setting.</param>
        public SchedulerMessagesSettingsBuilder<T> Views(Action<SchedulerMessagesViewsSettingsBuilder<T>> configurator)
        {

            Container.Views.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesViewsSettingsBuilder<T>(Container.Views));

            return this;
        }

    }
}
