using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorCategoryAxisSettingsPlotBand class
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettingsPlotBand<T> where T : class 
    {
        public string Color { get; set; }

        public double? From { get; set; }

        public double? Opacity { get; set; }

        public double? To { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (From.HasValue)
            {
                settings["from"] = From;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (To.HasValue)
            {
                settings["to"] = To;
            }

            return settings;
        }
    }
}
