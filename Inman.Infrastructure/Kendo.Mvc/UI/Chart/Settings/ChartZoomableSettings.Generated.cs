using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartZoomableSettings class
    /// </summary>
    public partial class ChartZoomableSettings<T> where T : class 
    {
        public ChartZoomableMousewheelSettings<T> Mousewheel { get; } = new ChartZoomableMousewheelSettings<T>();

        public ChartZoomableSelectionSettings<T> Selection { get; } = new ChartZoomableSelectionSettings<T>();

        public bool? Enabled { get; set; }

        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var mousewheel = Mousewheel.Serialize();
            if (mousewheel.Any())
            {
                settings["mousewheel"] = mousewheel;
            }
            else if (Mousewheel.Enabled.HasValue)
            {
                settings["mousewheel"] = Mousewheel.Enabled;
            }

            var selection = Selection.Serialize();
            if (selection.Any())
            {
                settings["selection"] = selection;
            }
            else if (Selection.Enabled.HasValue)
            {
                settings["selection"] = Selection.Enabled;
            }

            return settings;
        }
    }
}
