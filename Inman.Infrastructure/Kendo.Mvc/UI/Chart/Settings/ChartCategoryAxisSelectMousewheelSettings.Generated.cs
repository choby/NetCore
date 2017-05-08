using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxisSelectMousewheelSettings class
    /// </summary>
    public partial class ChartCategoryAxisSelectMousewheelSettings<T> where T : class 
    {
        public bool? Reverse { get; set; }

        public ChartZoomDirection? Zoom { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Reverse.HasValue)
            {
                settings["reverse"] = Reverse;
            }

            if (Zoom.HasValue)
            {
                settings["zoom"] = Zoom?.Serialize();
            }

            return settings;
        }
    }
}
