using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChart component
    /// </summary>
    public partial class StockChart<T> where T : class 
    {
        public string DateField { get; set; }

        public StockChartNavigatorSettings<T> Navigator { get; } = new StockChartNavigatorSettings<T>();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (DateField?.HasValue() == true)
            {
                settings["dateField"] = DateField;
            }

            var navigator = Navigator.Serialize();
            if (navigator.Any())
            {
                settings["navigator"] = navigator;
            }

            return settings;
        }
    }
}
