using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapMarker class
    /// </summary>
    public partial class MapMarker 
    {
        public double[] Location { get; set; }

        public string Title { get; set; }

        public MapMarkersShape? Shape { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Location?.Any() == true)
            {
                settings["location"] = Location;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            return settings;
        }
    }
}
