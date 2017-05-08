using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorWeekdaysSettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorWeekdaysSettings<T> where T : class, ISchedulerEvent 
    {
        public string Day { get; set; }

        public string Weekday { get; set; }

        public string Weekend { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Day?.HasValue() == true)
            {
                settings["day"] = Day;
            }

            if (Weekday?.HasValue() == true)
            {
                settings["weekday"] = Weekday;
            }

            if (Weekend?.HasValue() == true)
            {
                settings["weekend"] = Weekend;
            }

            return settings;
        }
    }
}
