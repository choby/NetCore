using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesHighlightSettings class
    /// </summary>
    public partial class ChartSeriesHighlightSettings<T> where T : class 
    {
        public ChartSeriesHighlightBorderSettings<T> Border { get; } = new ChartSeriesHighlightBorderSettings<T>();

        public string Color { get; set; }

        public ChartSeriesHighlightLineSettings<T> Line { get; } = new ChartSeriesHighlightLineSettings<T>();

        public double? Opacity { get; set; }

        public ClientHandlerDescriptor Toggle { get; set; }

        public bool? Visible { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
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

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Toggle?.HasValue() == true)
            {
                settings["toggle"] = Toggle;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            return settings;
        }
    }
}
