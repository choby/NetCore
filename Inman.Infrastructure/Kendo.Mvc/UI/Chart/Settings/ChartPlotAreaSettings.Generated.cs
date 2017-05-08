using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartPlotAreaSettings class
    /// </summary>
    public partial class ChartPlotAreaSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartPlotAreaBorderSettings<T> Border { get; } = new ChartPlotAreaBorderSettings<T>();

        public ChartPlotAreaMarginSettings<T> Margin { get; } = new ChartPlotAreaMarginSettings<T>();

        public double? Opacity { get; set; }

        public ChartPlotAreaPaddingSettings<T> Padding { get; } = new ChartPlotAreaPaddingSettings<T>();


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

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            return settings;
        }
    }
}
