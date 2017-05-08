using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesRecurrenceEditorEndSettings class
    /// </summary>
    public partial class SchedulerMessagesRecurrenceEditorEndSettings<T> where T : class, ISchedulerEvent 
    {
        public string After { get; set; }

        public string Occurrence { get; set; }

        public string Label { get; set; }

        public string Never { get; set; }

        public string MobileLabel { get; set; }

        public string On { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (After?.HasValue() == true)
            {
                settings["after"] = After;
            }

            if (Occurrence?.HasValue() == true)
            {
                settings["occurrence"] = Occurrence;
            }

            if (Label?.HasValue() == true)
            {
                settings["label"] = Label;
            }

            if (Never?.HasValue() == true)
            {
                settings["never"] = Never;
            }

            if (MobileLabel?.HasValue() == true)
            {
                settings["mobileLabel"] = MobileLabel;
            }

            if (On?.HasValue() == true)
            {
                settings["on"] = On;
            }

            return settings;
        }
    }
}
