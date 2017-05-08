using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ContextMenu component
    /// </summary>
    public partial class ContextMenu 
    {
        public bool? AlignToAnchor { get; set; }

        public string AppendTo { get; set; }

        public bool? CloseOnClick { get; set; }

        public string Filter { get; set; }

        public double? HoverDelay { get; set; }

        public string ShowOn { get; set; }

        public string Target { get; set; }

        public ContextMenuOrientation? Orientation { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AppendTo?.HasValue() == true)
            {
                settings["appendTo"] = AppendTo;
            }

            if (Filter?.HasValue() == true)
            {
                settings["filter"] = Filter;
            }

            if (HoverDelay.HasValue)
            {
                settings["hoverDelay"] = HoverDelay;
            }

            if (ShowOn?.HasValue() == true)
            {
                settings["showOn"] = ShowOn;
            }

            if (Target?.HasValue() == true)
            {
                settings["target"] = Target;
            }

            return settings;
        }
    }
}
