using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorYearlySettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorYearlySettings<T> where T : class, ISchedulerEvent 
    {
        public string Of { get; set; }

        public string RepeatEvery { get; set; }

        public string RepeatOn { get; set; }

        public string Interval { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Of?.HasValue() == true)
            {
                settings["of"] = Of;
            }

            if (RepeatEvery?.HasValue() == true)
            {
                settings["repeatEvery"] = RepeatEvery;
            }

            if (RepeatOn?.HasValue() == true)
            {
                settings["repeatOn"] = RepeatOn;
            }

            if (Interval?.HasValue() == true)
            {
                settings["interval"] = Interval;
            }

            return settings;
        }
    }
}
