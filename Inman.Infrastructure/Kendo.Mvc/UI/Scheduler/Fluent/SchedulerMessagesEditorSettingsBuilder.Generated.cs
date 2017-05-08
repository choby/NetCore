using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesEditorSettings
    /// </summary>
    public partial class SchedulerMessagesEditorSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "All day event" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for AllDayEvent</param>
        public SchedulerMessagesEditorSettingsBuilder<T> AllDayEvent(string value)
        {
            Container.AllDayEvent = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Description" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for Description</param>
        public SchedulerMessagesEditorSettingsBuilder<T> Description(string value)
        {
            Container.Description = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Event" displayed as title of the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for EditorTitle</param>
        public SchedulerMessagesEditorSettingsBuilder<T> EditorTitle(string value)
        {
            Container.EditorTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "End" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for End</param>
        public SchedulerMessagesEditorSettingsBuilder<T> End(string value)
        {
            Container.End = value;
            return this;
        }

        /// <summary>
        /// The text similar to "End timezone" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for EndTimezone</param>
        public SchedulerMessagesEditorSettingsBuilder<T> EndTimezone(string value)
        {
            Container.EndTimezone = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Repeat" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for Repeat</param>
        public SchedulerMessagesEditorSettingsBuilder<T> Repeat(string value)
        {
            Container.Repeat = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Use separate start and end time zones" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for SeparateTimezones</param>
        public SchedulerMessagesEditorSettingsBuilder<T> SeparateTimezones(string value)
        {
            Container.SeparateTimezones = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Start" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for Start</param>
        public SchedulerMessagesEditorSettingsBuilder<T> Start(string value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Start timezone" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for StartTimezone</param>
        public SchedulerMessagesEditorSettingsBuilder<T> StartTimezone(string value)
        {
            Container.StartTimezone = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Timezone" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for Timezone</param>
        public SchedulerMessagesEditorSettingsBuilder<T> Timezone(string value)
        {
            Container.Timezone = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Time zone" displayed as text of timezone editor button in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for TimezoneEditorButton</param>
        public SchedulerMessagesEditorSettingsBuilder<T> TimezoneEditorButton(string value)
        {
            Container.TimezoneEditorButton = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Timezones" displayed as title of timezone editor in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for TimezoneEditorTitle</param>
        public SchedulerMessagesEditorSettingsBuilder<T> TimezoneEditorTitle(string value)
        {
            Container.TimezoneEditorTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Title of the event" displayed in the scheduler event editor.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public SchedulerMessagesEditorSettingsBuilder<T> Title(string value)
        {
            Container.Title = value;
            return this;
        }

    }
}
