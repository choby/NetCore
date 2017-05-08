using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGaugeScaleLabelsSettings class
    /// </summary>
    public partial class RadialGaugeScaleLabelsSettings 
    {
        public string Background { get; set; }

        public RadialGaugeScaleLabelsBorderSettings Border { get; } = new RadialGaugeScaleLabelsBorderSettings();

        public string Color { get; set; }

        public string Font { get; set; }

        public string Format { get; set; }

        public RadialGaugeScaleLabelsMarginSettings Margin { get; } = new RadialGaugeScaleLabelsMarginSettings();

        public RadialGaugeScaleLabelsPaddingSettings Padding { get; } = new RadialGaugeScaleLabelsPaddingSettings();

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }

        public GaugeRadialScaleLabelsPosition? Position { get; set; }


        public RadialGauge RadialGauge { get; set; }

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

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
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
                        "jQuery('{0}{1}').html()", RadialGauge.IdPrefix, TemplateId
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

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            return settings;
        }
    }
}
