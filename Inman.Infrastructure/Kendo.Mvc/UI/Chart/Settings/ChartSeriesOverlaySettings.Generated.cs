using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesOverlaySettings class
    /// </summary>
    public partial class ChartSeriesOverlaySettings<T> where T : class 
    {
        public ChartSeriesGradient? Gradient { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Gradient.HasValue)
            {
                settings["gradient"] = Gradient?.Serialize();
            }

            return settings;
        }
    }
}
