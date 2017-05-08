using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartZoomableMousewheelSettings class
    /// </summary>
    public partial class ChartZoomableMousewheelSettings<T> where T : class 
    {
        public ChartAxisLock? Lock { get; set; }

        public bool? Enabled { get; set; }

        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Lock.HasValue)
            {
                settings["lock"] = Lock?.Serialize();
            }

            return settings;
        }
    }
}
