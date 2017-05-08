using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSeriesHighlightSettings class
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightSettings<T> where T : class 
    {
        public StockChartNavigatorSeriesHighlightBorderSettings<T> Border { get; } = new StockChartNavigatorSeriesHighlightBorderSettings<T>();

        public string Color { get; set; }

        public StockChartNavigatorSeriesHighlightLineSettings<T> Line { get; } = new StockChartNavigatorSeriesHighlightLineSettings<T>();

        public double? Opacity { get; set; }

        public bool? Visible { get; set; }


        public StockChart<T> StockChart { get; set; }

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

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
