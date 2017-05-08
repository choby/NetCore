using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorWeeklySettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorWeeklySettings<T> where T : class, ISchedulerEvent 
    {
        public string Interval { get; set; }

        public string RepeatEvery { get; set; }

        public string RepeatOn { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Interval?.HasValue() == true)
            {
                settings["interval"] = Interval;
            }

            if (RepeatEvery?.HasValue() == true)
            {
                settings["repeatEvery"] = RepeatEvery;
            }

            if (RepeatOn?.HasValue() == true)
            {
                settings["repeatOn"] = RepeatOn;
            }

            return settings;
        }
    }
}
