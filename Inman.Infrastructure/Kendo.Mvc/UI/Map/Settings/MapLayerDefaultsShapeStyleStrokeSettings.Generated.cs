using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsShapeStyleStrokeSettings class
    /// </summary>
    public partial class MapLayerDefaultsShapeStyleStrokeSettings 
    {
        public string Color { get; set; }

        public string DashType { get; set; }

        public double? Opacity { get; set; }

        public double? Width { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (DashType?.HasValue() == true)
            {
                settings["dashType"] = DashType;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
