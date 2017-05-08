using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGaugeScaleLabelsSettings class
    /// </summary>
    public partial class LinearGaugeScaleLabelsSettings 
    {
        public string Background { get; set; }

        public LinearGaugeScaleLabelsBorderSettings Border { get; } = new LinearGaugeScaleLabelsBorderSettings();

        public string Color { get; set; }

        public string Font { get; set; }

        public string Format { get; set; }

        public LinearGaugeScaleLabelsMarginSettings Margin { get; } = new LinearGaugeScaleLabelsMarginSettings();

        public LinearGaugeScaleLabelsPaddingSettings Padding { get; } = new LinearGaugeScaleLabelsPaddingSettings();

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }


        public LinearGauge LinearGauge { get; set; }

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
                        "jQuery('{0}{1}').html()", LinearGauge.IdPrefix, TemplateId
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
