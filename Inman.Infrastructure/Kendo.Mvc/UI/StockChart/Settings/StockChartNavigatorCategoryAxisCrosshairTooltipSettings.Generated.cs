using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorCategoryAxisCrosshairTooltipSettings class
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisCrosshairTooltipSettings<T> where T : class 
    {
        public string Background { get; set; }

        public StockChartNavigatorCategoryAxisCrosshairTooltipBorderSettings<T> Border { get; } = new StockChartNavigatorCategoryAxisCrosshairTooltipBorderSettings<T>();

        public string Color { get; set; }

        public string Font { get; set; }

        public string Format { get; set; }

        public StockChartNavigatorCategoryAxisCrosshairTooltipPaddingSettings<T> Padding { get; } = new StockChartNavigatorCategoryAxisCrosshairTooltipPaddingSettings<T>();

        public string Template { get; set; }

        public string TemplateId { get; set; }

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

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", StockChart.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
