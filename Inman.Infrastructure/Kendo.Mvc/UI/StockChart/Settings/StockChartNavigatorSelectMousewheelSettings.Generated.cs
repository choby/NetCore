using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSelectMousewheelSettings class
    /// </summary>
    public partial class StockChartNavigatorSelectMousewheelSettings<T> where T : class 
    {
        public bool? Reverse { get; set; }

        public string Zoom { get; set; }

        public bool? Enabled { get; set; }

        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Reverse.HasValue)
            {
                settings["reverse"] = Reverse;
            }

            if (Zoom?.HasValue() == true)
            {
                settings["zoom"] = Zoom;
            }

            return settings;
        }
    }
}
