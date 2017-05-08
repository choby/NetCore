using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerStyleSettings class
    /// </summary>
    public partial class MapLayerStyleSettings 
    {
        public MapLayerStyleFillSettings Fill { get; } = new MapLayerStyleFillSettings();

        public MapLayerStyleStrokeSettings Stroke { get; } = new MapLayerStyleStrokeSettings();


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
