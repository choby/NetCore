using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorSettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorSettings<T> where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesRecurrenceEditorDailySettings<T> Daily { get; } = new SchedulerMessagesRecurrenceEditorDailySettings<T>();

        public SchedulerMessagesRecurrenceEditorEndSettings<T> End { get; } = new SchedulerMessagesRecurrenceEditorEndSettings<T>();

        public SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> Frequencies { get; } = new SchedulerMessagesRecurrenceEditorFrequenciesSettings<T>();

        public SchedulerMessagesRecurrenceEditorMonthlySettings<T> Monthly { get; } = new SchedulerMessagesRecurrenceEditorMonthlySettings<T>();

        public SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> OffsetPositions { get; } = new SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T>();

        public SchedulerMessagesRecurrenceEditorWeeklySettings<T> Weekly { get; } = new SchedulerMessagesRecurrenceEditorWeeklySettings<T>();

        public SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> Weekdays { get; } = new SchedulerMessagesRecurrenceEditorWeekdaysSettings<T>();

        public SchedulerMessagesRecurrenceEditorYearlySettings<T> Yearly { get; } = new SchedulerMessagesRecurrenceEditorYearlySettings<T>();


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var daily = Daily.Serialize();
            if (daily.Any())
            {
                settings["daily"] = daily;
            }

            var end = End.Serialize();
            if (end.Any())
            {
                settings["end"] = end;
            }

            var frequencies = Frequencies.Serialize();
            if (frequencies.Any())
            {
                settings["frequencies"] = frequencies;
            }

            var monthly = Monthly.Serialize();
            if (monthly.Any())
            {
                settings["monthly"] = monthly;
            }

            var offsetPositions = OffsetPositions.Serialize();
            if (offsetPositions.Any())
            {
                settings["offsetPositions"] = offsetPositions;
            }

            var weekly = Weekly.Serialize();
            if (weekly.Any())
            {
                settings["weekly"] = weekly;
            }

            var weekdays = Weekdays.Serialize();
            if (weekdays.Any())
            {
                settings["weekdays"] = weekdays;
            }

            var yearly = Yearly.Serialize();
            if (yearly.Any())
            {
                settings["yearly"] = yearly;
            }

            return settings;
        }
    }
}
