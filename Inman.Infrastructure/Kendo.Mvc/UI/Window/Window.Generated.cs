using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Window component
    /// </summary>
    public partial class Window 
    {
        public bool? AutoFocus { get; set; }

        public bool? Draggable { get; set; }

        public bool? Iframe { get; set; }

        public double? Height { get; set; }

        public double? MaxHeight { get; set; }

        public double? MaxWidth { get; set; }

        public double? MinHeight { get; set; }

        public double? MinWidth { get; set; }

        public bool? Modal { get; set; }

        public bool? Pinned { get; set; }

        public WindowPositionSettings Position { get; } = new WindowPositionSettings();

        public bool? Scrollable { get; set; }

        public string Title { get; set; }

        public bool? Visible { get; set; }

        public double? Width { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoFocus.HasValue)
            {
                settings["autoFocus"] = AutoFocus;
            }

            if (Draggable.HasValue)
            {
                settings["draggable"] = Draggable;
            }

            if (Iframe.HasValue)
            {
                settings["iframe"] = Iframe;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (MaxHeight.HasValue)
            {
                settings["maxHeight"] = MaxHeight;
            }

            if (MaxWidth.HasValue)
            {
                settings["maxWidth"] = MaxWidth;
            }

            if (MinHeight.HasValue)
            {
                settings["minHeight"] = MinHeight;
            }

            if (MinWidth.HasValue)
            {
                settings["minWidth"] = MinWidth;
            }

            if (Modal.HasValue)
            {
                settings["modal"] = Modal;
            }

            if (Pinned.HasValue)
            {
                settings["pinned"] = Pinned;
            }

            var position = Position.Serialize();
            if (position.Any())
            {
                settings["position"] = position;
            }

            if (Scrollable.HasValue)
            {
                settings["scrollable"] = Scrollable;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
