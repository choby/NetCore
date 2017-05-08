using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesLabelsSettings class
    /// </summary>
    public partial class ChartSeriesLabelsSettings<T> where T : class 
    {
        public string Background { get; set; }
        public ClientHandlerDescriptor BackgroundHandler { get; set; }

        public ChartSeriesLabelsBorderSettings<T> Border { get; } = new ChartSeriesLabelsBorderSettings<T>();

        public string Color { get; set; }
        public ClientHandlerDescriptor ColorHandler { get; set; }

        public double? Distance { get; set; }

        public string Font { get; set; }
        public ClientHandlerDescriptor FontHandler { get; set; }

        public string Format { get; set; }
        public ClientHandlerDescriptor FormatHandler { get; set; }

        public ChartSeriesLabelsMarginSettings<T> Margin { get; } = new ChartSeriesLabelsMarginSettings<T>();

        public ChartSeriesLabelsPaddingSettings<T> Padding { get; } = new ChartSeriesLabelsPaddingSettings<T>();

        public string Rotation { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }

        public ChartSeriesLabelsFromSettings<T> From { get; } = new ChartSeriesLabelsFromSettings<T>();

        public ChartSeriesLabelsToSettings<T> To { get; } = new ChartSeriesLabelsToSettings<T>();

        public ChartSeriesLabelsAlign? Align { get; set; }

        public ChartSeriesLabelsPosition? Position { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (BackgroundHandler?.HasValue() == true)
            {
                settings["background"] = BackgroundHandler;
            }
            else if (Background?.HasValue() == true)
            {
               settings["background"] = Background;
            }


            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (ColorHandler?.HasValue() == true)
            {
                settings["color"] = ColorHandler;
            }
            else if (Color?.HasValue() == true)
            {
               settings["color"] = Color;
            }


            if (Distance.HasValue)
            {
                settings["distance"] = Distance;
            }

            if (FontHandler?.HasValue() == true)
            {
                settings["font"] = FontHandler;
            }
            else if (Font?.HasValue() == true)
            {
               settings["font"] = Font;
            }


            if (FormatHandler?.HasValue() == true)
            {
                settings["format"] = FormatHandler;
            }
            else if (Format?.HasValue() == true)
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

            if (Rotation?.HasValue() == true)
            {
                settings["rotation"] = Rotation;
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

            var from = From.Serialize();
            if (from.Any())
            {
                settings["from"] = from;
            }

            var to = To.Serialize();
            if (to.Any())
            {
                settings["to"] = to;
            }

            if (Align.HasValue)
            {
                settings["align"] = Align?.Serialize();
            }

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            return settings;
        }
    }
}
