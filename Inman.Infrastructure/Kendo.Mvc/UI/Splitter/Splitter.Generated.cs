using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Splitter component
    /// </summary>
    public partial class Splitter 
    {
        public List<SplitterPane> Panes { get; set; } = new List<SplitterPane>();

        public SplitterOrientation? Orientation { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var panes = Panes.Select(i => i.Serialize());
            if (panes.Any())
            {
                settings["panes"] = panes;
            }

            if (Orientation.HasValue)
            {
                settings["orientation"] = Orientation?.Serialize();
            }

            return settings;
        }
    }
}
