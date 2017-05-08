using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorOffsetPositionsSettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorOffsetPositionsSettings<T> where T : class, ISchedulerEvent 
    {
        public string First { get; set; }

        public string Second { get; set; }

        public string Third { get; set; }

        public string Fourth { get; set; }

        public string Last { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (First?.HasValue() == true)
            {
                settings["first"] = First;
            }

            if (Second?.HasValue() == true)
            {
                settings["second"] = Second;
            }

            if (Third?.HasValue() == true)
            {
                settings["third"] = Third;
            }

            if (Fourth?.HasValue() == true)
            {
                settings["fourth"] = Fourth;
            }

            if (Last?.HasValue() == true)
            {
                settings["last"] = Last;
            }

            return settings;
        }
    }
}
