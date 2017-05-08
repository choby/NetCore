using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class WindowTagHelper
    {
        /// <summary>
        /// Determines whether the Window will be focused automatically when opened. The property also influences the focus behavior when the Window is clicked when already opened.
        /// </summary>
        public bool? AutoFocus { get; set; }

        /// <summary>
        /// Enables (true) or disables (false) the ability for users to move/drag the widget.
        /// </summary>
        public bool? Draggable { get; set; }

        /// <summary>
        /// Explicitly states whether a content iframe should be created. For more information, please read Using iframes.
        /// </summary>
        public bool? Iframe { get; set; }

        /// <summary>
        /// Specifies height of the window.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// The maximum height (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public double? MaxHeight { get; set; }

        /// <summary>
        /// The maximum width (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public double? MaxWidth { get; set; }

        /// <summary>
        /// The minimum height (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public double? MinHeight { get; set; }

        /// <summary>
        /// The minimum width (in pixels) that may be achieved by resizing the window.
        /// </summary>
        public double? MinWidth { get; set; }

        /// <summary>
        /// Specifies whether the window should show a modal overlay over the page.
        /// </summary>
        public bool? Modal { get; set; }

        /// <summary>
        /// Specifies whether the window should be pinned, i.e. it will not move together with the page content during scrolling.
        /// </summary>
        public bool? Pinned { get; set; }

        /// <summary>
        /// Enables (true) or disables (false) the ability for users to scroll the window contents.
        /// </summary>
        public bool? Scrollable { get; set; }

        /// <summary>
        /// The text in the window title bar. If false, the window will be displayed without a title bar. Note that this will prevent the window from being dragged, and the window titlebar buttons will not be shown.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Specifies whether the window will be initially visible.
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        /// Specifies width of the window.
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Enables or disables the ability for users to resize a Window.
        /// </summary>
        public bool? Resizable { get; set; }

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

            if (Resizable.HasValue)
            {
                settings["resizable"] = Resizable;
            }

            return settings;
        }
    }
}
