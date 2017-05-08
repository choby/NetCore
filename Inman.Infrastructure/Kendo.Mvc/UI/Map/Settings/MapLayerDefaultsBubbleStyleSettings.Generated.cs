using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsBubbleStyleSettings class
    /// </summary>
    public partial class MapLayerDefaultsBubbleStyleSettings 
    {
        public MapLayerDefaultsBubbleStyleFillSettings Fill { get; } = new MapLayerDefaultsBubbleStyleFillSettings();

        public MapLayerDefaultsBubbleStyleStrokeSettings Stroke { get; } = new MapLayerDefaultsBubbleStyleStrokeSettings();


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
