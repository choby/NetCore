using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesLineSettings class
    /// </summary>
    public partial class ChartSeriesLineSettings<T> where T : class 
    {
        public string Color { get; set; }

        public double? Opacity { get; set; }

        public string Width { get; set; }

        public ChartSeriesLineStyle? Style { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Width?.HasValue() == true)
            {
                settings["width"] = Width;
            }

            if (Style.HasValue)
            {
                settings["style"] = Style?.Serialize();
            }

            return settings;
        }
    }
}
