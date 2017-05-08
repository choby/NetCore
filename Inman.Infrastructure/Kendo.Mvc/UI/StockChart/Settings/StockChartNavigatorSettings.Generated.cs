using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSettings class
    /// </summary>
    public partial class StockChartNavigatorSettings<T> where T : class 
    {
        public StockChartNavigatorCategoryAxisSettings<T> CategoryAxis { get; } = new StockChartNavigatorCategoryAxisSettings<T>();

        public bool? AutoBind { get; set; }

        public string DateField { get; set; }

        public StockChartNavigatorPaneSettings<T> Pane { get; } = new StockChartNavigatorPaneSettings<T>();

        public bool? Visible { get; set; }

        public StockChartNavigatorSelectSettings<T> Select { get; } = new StockChartNavigatorSelectSettings<T>();

        public StockChartNavigatorHintSettings<T> Hint { get; } = new StockChartNavigatorHintSettings<T>();


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var categoryAxis = CategoryAxis.Serialize();
            if (categoryAxis.Any())
            {
                settings["categoryAxis"] = categoryAxis;
            }

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (DateField?.HasValue() == true)
            {
                settings["dateField"] = DateField;
            }

            var pane = Pane.Serialize();
            if (pane.Any())
            {
                settings["pane"] = pane;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            var select = Select.Serialize();
            if (select.Any())
            {
                settings["select"] = select;
            }

            var hint = Hint.Serialize();
            if (hint.Any())
            {
                settings["hint"] = hint;
            }

            return settings;
        }
    }
}
