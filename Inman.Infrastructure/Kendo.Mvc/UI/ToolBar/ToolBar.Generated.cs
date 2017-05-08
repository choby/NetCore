using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ToolBar component
    /// </summary>
    public partial class ToolBar 
    {
        public bool? Resizable { get; set; }

        public List<ToolBarItem> Items { get; set; } = new List<ToolBarItem>();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Resizable.HasValue)
            {
                settings["resizable"] = Resizable;
            }

            var items = Items.Select(i => i.Serialize());
            if (items.Any())
            {
                settings["items"] = items;
            }

            return settings;
        }
    }
}
