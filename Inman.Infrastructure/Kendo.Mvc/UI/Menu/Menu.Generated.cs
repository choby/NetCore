using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Menu component
    /// </summary>
    public partial class Menu 
    {
        public bool? CloseOnClick { get; set; }

        public double? HoverDelay { get; set; }

        public bool? OpenOnClick { get; set; }

        public MenuOrientation? Orientation { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (HoverDelay.HasValue)
            {
                settings["hoverDelay"] = HoverDelay;
            }

            return settings;
        }
    }
}
