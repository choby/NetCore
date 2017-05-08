using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapMarkerDefaultsSettings class
    /// </summary>
    public partial class MapMarkerDefaultsSettings 
    {
        public MapMarkersShape? Shape { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            return settings;
        }
    }
}
