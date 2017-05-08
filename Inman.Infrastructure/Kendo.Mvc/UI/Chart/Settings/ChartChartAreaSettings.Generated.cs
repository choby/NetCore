using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartChartAreaSettings class
    /// </summary>
    public partial class ChartChartAreaSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartChartAreaBorderSettings<T> Border { get; } = new ChartChartAreaBorderSettings<T>();

        public double? Height { get; set; }

        public ChartChartAreaMarginSettings<T> Margin { get; } = new ChartChartAreaMarginSettings<T>();

        public double? Opacity { get; set; }

        public double? Width { get; set; }


        public Chart<T> Chart { get; set; }

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

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
