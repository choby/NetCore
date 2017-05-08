using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesEditableSettings class
    /// </summary>
    public partial class SchedulerMessagesEditableSettings<T> where T : class, ISchedulerEvent 
    {
        public string Confirmation { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Confirmation?.HasValue() == true)
            {
                settings["confirmation"] = Confirmation;
            }

            return settings;
        }
    }
}
