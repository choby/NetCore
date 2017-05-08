using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxisLabelsSettings class
    /// </summary>
    public partial class ChartCategoryAxisLabelsSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartCategoryAxisLabelsBorderSettings<T> Border { get; } = new ChartCategoryAxisLabelsBorderSettings<T>();

        public string Color { get; set; }

        public string Culture { get; set; }

        public ChartCategoryAxisLabelsDateFormatsSettings<T> DateFormats { get; } = new ChartCategoryAxisLabelsDateFormatsSettings<T>();

        public string Font { get; set; }

        public string Format { get; set; }

        public ChartCategoryAxisLabelsMarginSettings<T> Margin { get; } = new ChartCategoryAxisLabelsMarginSettings<T>();

        public bool? Mirror { get; set; }

        public ChartCategoryAxisLabelsPaddingSettings<T> Padding { get; } = new ChartCategoryAxisLabelsPaddingSettings<T>();

        public ChartCategoryAxisLabelsRotationSettings<T> Rotation { get; } = new ChartCategoryAxisLabelsRotationSettings<T>();

        public double? Skip { get; set; }

        public double? Step { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }


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

            if (Culture?.HasValue() == true)
            {
                settings["culture"] = Culture;
            }

            var dateFormats = DateFormats.Serialize();
            if (dateFormats.Any())
            {
                settings["dateFormats"] = dateFormats;
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

            if (Mirror.HasValue)
            {
                settings["mirror"] = Mirror;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            var rotation = Rotation.Serialize();
            if (rotation.Any())
            {
                settings["rotation"] = rotation;
            }

            if (Skip.HasValue)
            {
                settings["skip"] = Skip;
            }

            if (Step.HasValue)
            {
                settings["step"] = Step;
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

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            return settings;
        }
    }
}
