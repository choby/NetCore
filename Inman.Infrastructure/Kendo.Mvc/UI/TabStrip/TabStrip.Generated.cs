using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TabStrip component
    /// </summary>
    public partial class TabStrip 
    {
        public bool? Collapsible { get; set; }

        public bool? Navigatable { get; set; }

        public TabStripScrollableSettings Scrollable { get; } = new TabStripScrollableSettings();

        public TabStripTabPosition? TabPosition { get; set; }

        public string Value { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Collapsible.HasValue)
            {
                settings["collapsible"] = Collapsible;
            }

            if (Navigatable.HasValue)
            {
                settings["navigatable"] = Navigatable;
            }

            var scrollable = Scrollable.Serialize();
            if (scrollable.Any())
            {
                settings["scrollable"] = scrollable;
            }
            else if (Scrollable.Enabled.HasValue)
            {
                settings["scrollable"] = Scrollable.Enabled;
            }

            if (TabPosition.HasValue)
            {
                settings["tabPosition"] = TabPosition?.Serialize();
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            return settings;
        }
    }
}
