using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerFooterSettings class
    /// </summary>
    public partial class SchedulerFooterSettings<T> where T : class, ISchedulerEvent 
    {
        public string Command { get; set; }

        public bool? Enabled { get; set; }

        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Command?.HasValue() == true)
            {
                settings["command"] = Command;
            }

            return settings;
        }
    }
}
