using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class ResponsivePanelTagHelper
    {
        /// <summary>
        /// If set to false the widget will not close when the page content is touched, after it was opened on a mobile device. You will need to call the close method when the panel needs to close.
        /// </summary>
        public bool? AutoClose { get; set; }

        /// <summary>
        /// Specifies the page width at which the widget will be hidden and its toggle button will become visible.
        /// </summary>
        public double? Breakpoint { get; set; }

        /// <summary>
        /// Specifies the direction from which the hidden element will open up, once the toggle button has been activated. Valid values are "left", "right", and "top".
        /// </summary>
        public string Orientation { get; set; }

        /// <summary>
        /// Specifies the selector for the toggle button that will show and hide the responsive panel.
        /// </summary>
        public string ToggleButton { get; set; }

        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoClose.HasValue)
            {
                settings["autoClose"] = AutoClose;
            }

            if (Breakpoint.HasValue)
            {
                settings["breakpoint"] = Breakpoint;
            }

            if (Orientation?.HasValue() == true)
            {
                settings["orientation"] = Orientation;
            }

            if (ToggleButton?.HasValue() == true)
            {
                settings["toggleButton"] = ToggleButton;
            }

            return settings;
        }
    }
}
