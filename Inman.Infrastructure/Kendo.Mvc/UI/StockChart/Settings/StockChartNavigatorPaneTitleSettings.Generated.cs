using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorPaneTitleSettings class
    /// </summary>
    public partial class StockChartNavigatorPaneTitleSettings<T> where T : class 
    {
        public string Background { get; set; }

        public StockChartNavigatorPaneTitleBorderSettings<T> Border { get; } = new StockChartNavigatorPaneTitleBorderSettings<T>();

        public string Color { get; set; }

        public string Font { get; set; }

        public StockChartNavigatorPaneTitleMarginSettings<T> Margin { get; } = new StockChartNavigatorPaneTitleMarginSettings<T>();

        public string Position { get; set; }

        public string Text { get; set; }

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

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Font?.HasValue() == true)
            {
                settings["font"] = Font;
            }

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            if (Position?.HasValue() == true)
            {
                settings["position"] = Position;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
