using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartTooltipSettings class
    /// </summary>
    public partial class ChartTooltipSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartTooltipBorderSettings<T> Border { get; } = new ChartTooltipBorderSettings<T>();

        public string Color { get; set; }

        public string Font { get; set; }

        public string Format { get; set; }

        public double? Opacity { get; set; }

        public ChartTooltipPaddingSettings<T> Padding { get; } = new ChartTooltipPaddingSettings<T>();

        public bool? Shared { get; set; }

        public string SharedTemplate { get; set; }

        public string SharedTemplateId { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }


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

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            if (Shared.HasValue)
            {
                settings["shared"] = Shared;
            }

            if (SharedTemplateId.HasValue())
            {
                settings["sharedTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Chart.IdPrefix, SharedTemplateId
                    )
                };
            }
            else if (SharedTemplate.HasValue())
            {
                settings["sharedTemplate"] = SharedTemplate;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Chart.IdPrefix, TemplateId
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
