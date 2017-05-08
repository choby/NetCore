using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartPane class
    /// </summary>
    public partial class ChartPane<T> where T : class 
    {
        public string Background { get; set; }

        public ChartPaneBorderSettings<T> Border { get; } = new ChartPaneBorderSettings<T>();

        public bool? Clip { get; set; }

        public double? Height { get; set; }

        public ChartPaneMarginSettings<T> Margin { get; } = new ChartPaneMarginSettings<T>();

        public string Name { get; set; }

        public ChartPanePaddingSettings<T> Padding { get; } = new ChartPanePaddingSettings<T>();

        public ChartPaneTitleSettings<T> Title { get; } = new ChartPaneTitleSettings<T>();


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

            if (Clip.HasValue)
            {
                settings["clip"] = Clip;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            var title = Title.Serialize();
            if (title.Any())
            {
                settings["title"] = title;
            }

            return settings;
        }
    }
}
