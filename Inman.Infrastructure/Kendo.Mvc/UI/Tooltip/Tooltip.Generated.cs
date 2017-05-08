using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Tooltip component
    /// </summary>
    public partial class Tooltip 
    {
        public bool? AutoHide { get; set; }

        public bool? Callout { get; set; }

        public string Filter { get; set; }

        public bool? Iframe { get; set; }

        public double? Height { get; set; }

        public double? Width { get; set; }

        public double? ShowAfter { get; set; }

        public TooltipPosition? Position { get; set; }

        public TooltipShowOnEvent? ShowOn { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoHide.HasValue)
            {
                settings["autoHide"] = AutoHide;
            }

            if (Callout.HasValue)
            {
                settings["callout"] = Callout;
            }

            if (Iframe.HasValue)
            {
                settings["iframe"] = Iframe;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (ShowAfter.HasValue)
            {
                settings["showAfter"] = ShowAfter;
            }

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            if (ShowOn.HasValue)
            {
                settings["showOn"] = ShowOn?.Serialize();
            }

            return settings;
        }
    }
}
