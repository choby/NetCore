using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartLegendLabelsSettings class
    /// </summary>
    public partial class ChartLegendLabelsSettings<T> where T : class 
    {
        public string Color { get; set; }

        public string Font { get; set; }

        public ChartLegendLabelsMarginSettings<T> Margin { get; } = new ChartLegendLabelsMarginSettings<T>();

        public ChartLegendLabelsPaddingSettings<T> Padding { get; } = new ChartLegendLabelsPaddingSettings<T>();

        public string Template { get; set; }

        public string TemplateId { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Font?.HasValue() == true)
            {
                settings["font"] = Font;
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
                        "jQuery('{0}{1}').html()", Chart.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            return settings;
        }
    }
}
