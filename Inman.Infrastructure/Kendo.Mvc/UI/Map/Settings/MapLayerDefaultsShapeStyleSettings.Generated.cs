using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsShapeStyleSettings class
    /// </summary>
    public partial class MapLayerDefaultsShapeStyleSettings 
    {
        public MapLayerDefaultsShapeStyleFillSettings Fill { get; } = new MapLayerDefaultsShapeStyleFillSettings();

        public MapLayerDefaultsShapeStyleStrokeSettings Stroke { get; } = new MapLayerDefaultsShapeStyleStrokeSettings();


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var fill = Fill.Serialize();
            if (fill.Any())
            {
                settings["fill"] = fill;
            }

            var stroke = Stroke.Serialize();
            if (stroke.Any())
            {
                settings["stroke"] = stroke;
            }

            return settings;
        }
    }
}
