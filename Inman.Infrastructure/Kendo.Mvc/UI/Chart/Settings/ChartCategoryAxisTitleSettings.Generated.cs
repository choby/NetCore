using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxisTitleSettings class
    /// </summary>
    public partial class ChartCategoryAxisTitleSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartCategoryAxisTitleBorderSettings<T> Border { get; } = new ChartCategoryAxisTitleBorderSettings<T>();

        public string Color { get; set; }

        public string Font { get; set; }

        public ChartCategoryAxisTitleMarginSettings<T> Margin { get; } = new ChartCategoryAxisTitleMarginSettings<T>();

        public ChartCategoryAxisTitlePaddingSettings<T> Padding { get; } = new ChartCategoryAxisTitlePaddingSettings<T>();

        public double? Rotation { get; set; }

        public string Text { get; set; }

        public bool? Visible { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }

        public ChartAxisTitlePosition? Position { get; set; }


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

            if (Rotation.HasValue)
            {
                settings["rotation"] = Rotation;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            return settings;
        }
    }
}
