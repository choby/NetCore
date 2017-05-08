using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesLabelsToSettings class
    /// </summary>
    public partial class ChartSeriesLabelsToSettings<T> where T : class 
    {
        public string Background { get; set; }
        public ClientHandlerDescriptor BackgroundHandler { get; set; }

        public ChartSeriesLabelsToBorderSettings<T> Border { get; } = new ChartSeriesLabelsToBorderSettings<T>();

        public string Color { get; set; }
        public ClientHandlerDescriptor ColorHandler { get; set; }

        public string Font { get; set; }
        public ClientHandlerDescriptor FontHandler { get; set; }

        public string Format { get; set; }
        public ClientHandlerDescriptor FormatHandler { get; set; }

        public ChartSeriesLabelsToMarginSettings<T> Margin { get; } = new ChartSeriesLabelsToMarginSettings<T>();

        public ChartSeriesLabelsToPaddingSettings<T> Padding { get; } = new ChartSeriesLabelsToPaddingSettings<T>();

        public string Position { get; set; }
        public ClientHandlerDescriptor PositionHandler { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }


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

            if (PositionHandler?.HasValue() == true)
            {
                settings["position"] = PositionHandler;
            }
            else if (Position?.HasValue() == true)
            {
               settings["position"] = Position;
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
