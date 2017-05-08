using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSelectSettings class
    /// </summary>
    public partial class StockChartNavigatorSelectSettings<T> where T : class 
    {
        public DateTime? From { get; set; }

        public StockChartNavigatorSelectMousewheelSettings<T> Mousewheel { get; } = new StockChartNavigatorSelectMousewheelSettings<T>();

        public DateTime? To { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (From.HasValue)
            {
                settings["from"] = From;
            }

            var mousewheel = Mousewheel.Serialize();
            if (mousewheel.Any())
            {
                settings["mousewheel"] = mousewheel;
            }
            else if (Mousewheel.Enabled.HasValue)
            {
                settings["mousewheel"] = Mousewheel.Enabled;
            }

            if (To.HasValue)
            {
                settings["to"] = To;
            }

            return settings;
        }
    }
}
