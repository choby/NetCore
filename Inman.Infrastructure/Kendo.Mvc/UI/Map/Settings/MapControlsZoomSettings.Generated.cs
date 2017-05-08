using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapControlsZoomSettings class
    /// </summary>
    public partial class MapControlsZoomSettings 
    {
        public MapControlPosition? Position { get; set; }

        public bool? Enabled { get; set; }

        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Position.HasValue)
            {
                settings["position"] = Position?.Serialize();
            }

            return settings;
        }
    }
}
