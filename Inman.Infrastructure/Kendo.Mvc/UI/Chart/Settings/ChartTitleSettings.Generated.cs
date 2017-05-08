using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartTitleSettings class
    /// </summary>
    public partial class ChartTitleSettings<T> where T : class 
    {
        public string Background { get; set; }

        public ChartTitleBorderSettings<T> Border { get; } = new ChartTitleBorderSettings<T>();

        public string Color { get; set; }

        public string Font { get; set; }

        public ChartTitleMarginSettings<T> Margin { get; } = new ChartTitleMarginSettings<T>();

        public ChartTitlePaddingSettings<T> Padding { get; } = new ChartTitlePaddingSettings<T>();

        public string Text { get; set; }

        public bool? Visible { get; set; }

        public ChartTextAlignment? Align { get; set; }

        public ChartTitlePosition? Position { get; set; }


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

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
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
