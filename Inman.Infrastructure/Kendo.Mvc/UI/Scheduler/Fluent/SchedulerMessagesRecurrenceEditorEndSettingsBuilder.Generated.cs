using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorEndSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "After " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for After</param>
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> After(string value)
        {
            Container.After = value;
            return this;
        }

        /// <summary>
        /// The text similar to " occurrence(s)" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Occurrence</param>
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> Occurrence(string value)
        {
            Container.Occurrence = value;
            return this;
        }

        /// <summary>
        /// The text similar to "End:" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Label</param>
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> Label(string value)
        {
            Container.Label = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Never" displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for Never</param>
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> Never(string value)
        {
            Container.Never = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Ends" displayed in the adaptive version of the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for MobileLabel</param>
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> MobileLabel(string value)
        {
            Container.MobileLabel = value;
            return this;
        }

        /// <summary>
        /// The text similar to "On " displayed in the scheduler recurrence editor.
        /// </summary>
        /// <param name="value">The value for On</param>
        public SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T> On(string value)
        {
            Container.On = value;
            return this;
        }

    }
}
