using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSeriesMarkersSettings class
    /// </summary>
    public partial class StockChartNavigatorSeriesMarkersSettings<T> where T : class 
    {
        public string Background { get; set; }

        public StockChartNavigatorSeriesMarkersBorderSettings<T> Border { get; } = new StockChartNavigatorSeriesMarkersBorderSettings<T>();

        public double? Rotation { get; set; }

        public double? Size { get; set; }

        public string Type { get; set; }

        public bool? Visible { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (Rotation.HasValue)
            {
                settings["rotation"] = Rotation;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
