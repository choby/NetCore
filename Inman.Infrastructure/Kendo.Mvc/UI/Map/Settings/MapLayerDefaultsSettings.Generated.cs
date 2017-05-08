using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsSettings class
    /// </summary>
    public partial class MapLayerDefaultsSettings 
    {
        public MapLayerDefaultsMarkerSettings Marker { get; } = new MapLayerDefaultsMarkerSettings();

        public MapLayerDefaultsShapeSettings Shape { get; } = new MapLayerDefaultsShapeSettings();

        public MapLayerDefaultsBubbleSettings Bubble { get; } = new MapLayerDefaultsBubbleSettings();

        public double? TileSize { get; set; }

        public MapLayerDefaultsTileSettings Tile { get; } = new MapLayerDefaultsTileSettings();

        public MapLayerDefaultsBingSettings Bing { get; } = new MapLayerDefaultsBingSettings();


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var marker = Marker.Serialize();
            if (marker.Any())
            {
                settings["marker"] = marker;
            }

            var shape = Shape.Serialize();
            if (shape.Any())
            {
                settings["shape"] = shape;
            }

            var bubble = Bubble.Serialize();
            if (bubble.Any())
            {
                settings["bubble"] = bubble;
            }

            if (TileSize.HasValue)
            {
                settings["tileSize"] = TileSize;
            }

            var tile = Tile.Serialize();
            if (tile.Any())
            {
                settings["tile"] = tile;
            }

            var bing = Bing.Serialize();
            if (bing.Any())
            {
                settings["bing"] = bing;
            }

            return settings;
        }
    }
}
