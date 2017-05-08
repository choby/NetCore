using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSeriesOverlaySettings class
    /// </summary>
    public partial class StockChartNavigatorSeriesOverlaySettings<T> where T : class 
    {
        public string Gradient { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Gradient?.HasValue() == true)
            {
                settings["gradient"] = Gradient;
            }

            return settings;
        }
    }
}
