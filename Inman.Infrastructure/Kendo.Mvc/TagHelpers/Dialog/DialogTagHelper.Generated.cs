using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class DialogTagHelper
    {
        /// <summary>
        /// Specifies the possible layout of the action buttons in the Dialog.Possible values are:
        /// </summary>
        public string ButtonLayout { get; set; }

        /// <summary>
        /// Specifies whether a close button should be rendered at the top corner of the dialog.
        /// </summary>
        public bool? Closable { get; set; }

        /// <summary>
        /// Specifies height of the dialog.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// The maximum height (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        public double? MaxHeight { get; set; }

        /// <summary>
        /// The maximum width (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        public double? MaxWidth { get; set; }

        /// <summary>
        /// The minimum height (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        public double? MinHeight { get; set; }

        /// <summary>
        /// The minimum width (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        public double? MinWidth { get; set; }

        /// <summary>
        /// Specifies whether the dialog should show a modal overlay over the page.
        /// </summary>
        public bool? Modal { get; set; }

        /// <summary>
        /// The text in the dialog title bar. If false, the dialog will be displayed without a title bar.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Specifies whether the dialog will be initially visible.
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        /// Specifies width of the dialog.
        /// </summary>
        public double? Width { get; set; }

        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (ButtonLayout?.HasValue() == true)
            {
                settings["buttonLayout"] = ButtonLayout;
            }

            if (Closable.HasValue)
            {
                settings["closable"] = Closable;
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
