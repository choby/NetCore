using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsShapeSettings class
    /// </summary>
    public partial class MapLayerDefaultsShapeSettings 
    {
        public string Attribution { get; set; }

        public double? Opacity { get; set; }

        public MapLayerDefaultsShapeStyleSettings Style { get; } = new MapLayerDefaultsShapeStyleSettings();


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

            var style = Style.Serialize();
            if (style.Any())
            {
                settings["style"] = style;
            }

            return settings;
        }
    }
}
