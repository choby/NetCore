using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSeriesHighlightBorderSettings class
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightBorderSettings<T> where T : class 
    {
        public double? Width { get; set; }

        public string Color { get; set; }

        public double? Opacity { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            return settings;
        }
    }
}
