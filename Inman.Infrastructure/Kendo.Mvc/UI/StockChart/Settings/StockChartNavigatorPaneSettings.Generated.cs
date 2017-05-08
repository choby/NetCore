using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorPaneSettings class
    /// </summary>
    public partial class StockChartNavigatorPaneSettings<T> where T : class 
    {
        public string Background { get; set; }

        public StockChartNavigatorPaneBorderSettings<T> Border { get; } = new StockChartNavigatorPaneBorderSettings<T>();

        public double? Height { get; set; }

        public StockChartNavigatorPaneMarginSettings<T> Margin { get; } = new StockChartNavigatorPaneMarginSettings<T>();

        public string Name { get; set; }

        public StockChartNavigatorPanePaddingSettings<T> Padding { get; } = new StockChartNavigatorPanePaddingSettings<T>();

        public StockChartNavigatorPaneTitleSettings<T> Title { get; } = new StockChartNavigatorPaneTitleSettings<T>();


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

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            var title = Title.Serialize();
            if (title.Any())
            {
                settings["title"] = title;
            }

            return settings;
        }
    }
}
