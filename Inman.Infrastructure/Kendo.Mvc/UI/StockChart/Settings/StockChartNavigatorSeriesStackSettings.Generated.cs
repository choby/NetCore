using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSeriesStackSettings class
    /// </summary>
    public partial class StockChartNavigatorSeriesStackSettings<T> where T : class 
    {
        public string Type { get; set; }

        public string Group { get; set; }

        public bool? Enabled { get; set; }

        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (Group?.HasValue() == true)
            {
                settings["group"] = Group;
            }

            return settings;
        }
    }
}
