using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesHighlightLineSettings class
    /// </summary>
    public partial class ChartSeriesHighlightLineSettings<T> where T : class 
    {
        public ChartDashType? DashType { get; set; }

        public string Color { get; set; }

        public double? Opacity { get; set; }

        public double? Width { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
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
