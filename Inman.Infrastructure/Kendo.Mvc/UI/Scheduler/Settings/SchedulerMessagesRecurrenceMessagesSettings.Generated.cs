using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceMessagesSettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceMessagesSettings<T> where T : class, ISchedulerEvent 
    {
        public string DeleteRecurring { get; set; }

        public string DeleteWindowOccurrence { get; set; }

        public string DeleteWindowSeries { get; set; }

        public string DeleteWindowTitle { get; set; }

        public string EditRecurring { get; set; }

        public string EditWindowOccurrence { get; set; }

        public string EditWindowSeries { get; set; }

        public string EditWindowTitle { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (DeleteRecurring?.HasValue() == true)
            {
                settings["deleteRecurring"] = DeleteRecurring;
            }

            if (DeleteWindowOccurrence?.HasValue() == true)
            {
                settings["deleteWindowOccurrence"] = DeleteWindowOccurrence;
            }

            if (DeleteWindowSeries?.HasValue() == true)
            {
                settings["deleteWindowSeries"] = DeleteWindowSeries;
            }

            if (DeleteWindowTitle?.HasValue() == true)
            {
                settings["deleteWindowTitle"] = DeleteWindowTitle;
            }

            if (EditRecurring?.HasValue() == true)
            {
                settings["editRecurring"] = EditRecurring;
            }

            if (EditWindowOccurrence?.HasValue() == true)
            {
                settings["editWindowOccurrence"] = EditWindowOccurrence;
            }

            if (EditWindowSeries?.HasValue() == true)
            {
                settings["editWindowSeries"] = EditWindowSeries;
            }

            if (EditWindowTitle?.HasValue() == true)
            {
                settings["editWindowTitle"] = EditWindowTitle;
            }

            return settings;
        }
    }
}
