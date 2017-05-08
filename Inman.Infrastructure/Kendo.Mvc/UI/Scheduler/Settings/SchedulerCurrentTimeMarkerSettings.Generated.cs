using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerCurrentTimeMarkerSettings class
    /// </summary>
    public partial class SchedulerCurrentTimeMarkerSettings<T> where T : class, ISchedulerEvent 
    {
        public double? UpdateInterval { get; set; }

        public bool? UseLocalTimezone { get; set; }

        public bool? Enabled { get; set; }

        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (UpdateInterval.HasValue)
            {
                settings["updateInterval"] = UpdateInterval;
            }

            if (UseLocalTimezone.HasValue)
            {
                settings["useLocalTimezone"] = UseLocalTimezone;
            }

            return settings;
        }
    }
}
