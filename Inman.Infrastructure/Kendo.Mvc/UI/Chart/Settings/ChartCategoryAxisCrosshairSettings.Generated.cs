using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxisCrosshairSettings class
    /// </summary>
    public partial class ChartCategoryAxisCrosshairSettings<T> where T : class 
    {
        public string Color { get; set; }

        public ChartDashType? DashType { get; set; }

        public double? Opacity { get; set; }

        public ChartCategoryAxisCrosshairTooltipSettings<T> Tooltip { get; } = new ChartCategoryAxisCrosshairTooltipSettings<T>();

        public bool? Visible { get; set; }

        public double? Width { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            var tooltip = Tooltip.Serialize();
            if (tooltip.Any())
            {
                settings["tooltip"] = tooltip;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
