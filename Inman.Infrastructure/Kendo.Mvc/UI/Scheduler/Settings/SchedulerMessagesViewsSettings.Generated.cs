using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesViewsSettings class
    /// </summary>
    public partial class SchedulerMessagesViewsSettings<T> where T : class, ISchedulerEvent 
    {
        public string Day { get; set; }

        public string Week { get; set; }

        public string Month { get; set; }

        public string Agenda { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Day?.HasValue() == true)
            {
                settings["day"] = Day;
            }

            if (Week?.HasValue() == true)
            {
                settings["week"] = Week;
            }

            if (Month?.HasValue() == true)
            {
                settings["month"] = Month;
            }

            if (Agenda?.HasValue() == true)
            {
                settings["agenda"] = Agenda;
            }

            return settings;
        }
    }
}
