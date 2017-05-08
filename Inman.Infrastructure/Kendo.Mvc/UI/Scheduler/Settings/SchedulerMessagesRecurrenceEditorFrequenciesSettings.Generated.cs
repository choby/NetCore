using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorFrequenciesSettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorFrequenciesSettings<T> where T : class, ISchedulerEvent 
    {
        public string Daily { get; set; }

        public string Monthly { get; set; }

        public string Never { get; set; }

        public string Weekly { get; set; }

        public string Yearly { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Daily?.HasValue() == true)
            {
                settings["daily"] = Daily;
            }

            if (Monthly?.HasValue() == true)
            {
                settings["monthly"] = Monthly;
            }

            if (Never?.HasValue() == true)
            {
                settings["never"] = Never;
            }

            if (Weekly?.HasValue() == true)
            {
                settings["weekly"] = Weekly;
            }

            if (Yearly?.HasValue() == true)
            {
                settings["yearly"] = Yearly;
            }

            return settings;
        }
    }
}
