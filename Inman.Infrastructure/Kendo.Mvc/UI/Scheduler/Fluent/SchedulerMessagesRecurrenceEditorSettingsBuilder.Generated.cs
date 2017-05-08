using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesRecurrenceEditorSettings
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The configuration of the scheduler recurrence editor daily messages. Use this option to customize or localize the scheduler recurrence editor daily messages.
        /// </summary>
        /// <param name="configurator">The configurator for the daily setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Daily(Action<SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T>> configurator)
        {

            Container.Daily.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorDailySettingsBuilder<T>(Container.Daily));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor end messages. Use this option to customize or localize the scheduler recurrence editor end messages.
        /// </summary>
        /// <param name="configurator">The configurator for the end setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> End(Action<SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T>> configurator)
        {

            Container.End.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorEndSettingsBuilder<T>(Container.End));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor frequencies messages. Use this option to customize or localize the scheduler recurrence editor frequencies messages.
        /// </summary>
        /// <param name="configurator">The configurator for the frequencies setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Frequencies(Action<SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T>> configurator)
        {

            Container.Frequencies.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorFrequenciesSettingsBuilder<T>(Container.Frequencies));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor monthly messages. Use this option to customize or localize the scheduler recurrence editor monthly messages.
        /// </summary>
        /// <param name="configurator">The configurator for the monthly setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Monthly(Action<SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T>> configurator)
        {

            Container.Monthly.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorMonthlySettingsBuilder<T>(Container.Monthly));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor offsetPositions messages. Use this option to customize or localize the scheduler recurrence editor offsetPositions messages.
        /// </summary>
        /// <param name="configurator">The configurator for the offsetpositions setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> OffsetPositions(Action<SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T>> configurator)
        {

            Container.OffsetPositions.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorOffsetPositionsSettingsBuilder<T>(Container.OffsetPositions));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor weekly messages. Use this option to customize or localize the scheduler recurrence editor weekly messages.
        /// </summary>
        /// <param name="configurator">The configurator for the weekly setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Weekly(Action<SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T>> configurator)
        {

            Container.Weekly.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorWeeklySettingsBuilder<T>(Container.Weekly));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor week days messages. Use these options to customize or localize the scheduler recurrence editor weekdays messages.
        /// </summary>
        /// <param name="configurator">The configurator for the weekdays setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Weekdays(Action<SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T>> configurator)
        {

            Container.Weekdays.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorWeekdaysSettingsBuilder<T>(Container.Weekdays));

            return this;
        }

        /// <summary>
        /// The configuration of the scheduler recurrence editor yearly messages. Use this option to customize or localize the scheduler recurrence editor yearly messages.
        /// </summary>
        /// <param name="configurator">The configurator for the yearly setting.</param>
        public SchedulerMessagesRecurrenceEditorSettingsBuilder<T> Yearly(Action<SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T>> configurator)
        {

            Container.Yearly.Scheduler = Container.Scheduler;
            configurator(new SchedulerMessagesRecurrenceEditorYearlySettingsBuilder<T>(Container.Yearly));

            return this;
        }

    }
}
