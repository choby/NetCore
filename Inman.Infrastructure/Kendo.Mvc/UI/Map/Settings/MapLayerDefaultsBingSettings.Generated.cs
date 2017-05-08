using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsBingSettings class
    /// </summary>
    public partial class MapLayerDefaultsBingSettings 
    {
        public string Attribution { get; set; }

        public double? Opacity { get; set; }

        public string Key { get; set; }

        public string Culture { get; set; }

        public MapLayersImagerySet? ImagerySet { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Attribution?.HasValue() == true)
            {
                settings["attribution"] = Attribution;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Key?.HasValue() == true)
            {
                settings["key"] = Key;
            }

            if (Culture?.HasValue() == true)
            {
                settings["culture"] = Culture;
            }

            if (ImagerySet.HasValue)
            {
                settings["imagerySet"] = ImagerySet?.Serialize();
            }

            return settings;
        }
    }
}
