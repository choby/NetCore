using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapControlsSettings class
    /// </summary>
    public partial class MapControlsSettings 
    {
        public MapControlsAttributionSettings Attribution { get; } = new MapControlsAttributionSettings();

        public MapControlsNavigatorSettings Navigator { get; } = new MapControlsNavigatorSettings();

        public MapControlsZoomSettings Zoom { get; } = new MapControlsZoomSettings();


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var attribution = Attribution.Serialize();
            if (attribution.Any())
            {
                settings["attribution"] = attribution;
            }
            else if (Attribution.Enabled.HasValue)
            {
                settings["attribution"] = Attribution.Enabled;
            }

            var navigator = Navigator.Serialize();
            if (navigator.Any())
            {
                settings["navigator"] = navigator;
            }
            else if (Navigator.Enabled.HasValue)
            {
                settings["navigator"] = Navigator.Enabled;
            }

            var zoom = Zoom.Serialize();
            if (zoom.Any())
            {
                settings["zoom"] = zoom;
            }
            else if (Zoom.Enabled.HasValue)
            {
                settings["zoom"] = Zoom.Enabled;
            }

            return settings;
        }
    }
}
