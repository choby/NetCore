using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesErrorBarsSettings class
    /// </summary>
    public partial class ChartSeriesErrorBarsSettings<T> where T : class 
    {
        public string Value { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }

        public string XValue { get; set; }

        public string YValue { get; set; }

        public bool? EndCaps { get; set; }

        public string Color { get; set; }

        public ChartSeriesErrorBarsLineSettings<T> Line { get; } = new ChartSeriesErrorBarsLineSettings<T>();


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            if (XValue?.HasValue() == true)
            {
                settings["xValue"] = XValue;
            }

            if (YValue?.HasValue() == true)
            {
                settings["yValue"] = YValue;
            }

            if (EndCaps.HasValue)
            {
                settings["endCaps"] = EndCaps;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            return settings;
        }
    }
}
