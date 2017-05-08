using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxisNotesLabelSettings class
    /// </summary>
    public partial class ChartCategoryAxisNotesLabelSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartCategoryAxisNotesLabelBorderSettings<T> Border { get; } = new ChartCategoryAxisNotesLabelBorderSettings<T>();

        public string Color { get; set; }

        public string Font { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Visible { get; set; }

        public double? Rotation { get; set; }

        public string Format { get; set; }

        public ChartNoteLabelPosition? Position { get; set; }


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

            if (Rotation.HasValue)
            {
                settings["rotation"] = Rotation;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            return settings;
        }
    }
}
