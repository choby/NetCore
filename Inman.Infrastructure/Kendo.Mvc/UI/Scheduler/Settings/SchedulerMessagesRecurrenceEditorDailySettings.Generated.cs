using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorDailySettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorDailySettings<T> where T : class, ISchedulerEvent 
    {
        public string Interval { get; set; }

        public string RepeatEvery { get; set; }


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

            return settings;
        }
    }
}
