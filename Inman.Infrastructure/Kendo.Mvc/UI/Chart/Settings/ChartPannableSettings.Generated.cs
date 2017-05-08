using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartPannableSettings class
    /// </summary>
    public partial class ChartPannableSettings<T> where T : class 
    {
        public ChartActivationKey? Key { get; set; }

        public ChartAxisLock? Lock { get; set; }

        public bool? Enabled { get; set; }

        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Key.HasValue)
            {
                settings["key"] = Key?.Serialize();
            }

            if (Lock.HasValue)
            {
                settings["lock"] = Lock?.Serialize();
            }

            return settings;
        }
    }
}
