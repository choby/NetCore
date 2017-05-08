using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Map component
    /// </summary>
    public partial class Map 
    {
        public double[] Center { get; set; }

        public MapControlsSettings Controls { get; } = new MapControlsSettings();

        public MapLayerDefaultsSettings LayerDefaults { get; } = new MapLayerDefaultsSettings();

        public List<MapLayer> Layers { get; set; } = new List<MapLayer>();

        public MapMarkerDefaultsSettings MarkerDefaults { get; } = new MapMarkerDefaultsSettings();

        public List<MapMarker> Markers { get; set; } = new List<MapMarker>();

        public double? MinZoom { get; set; }

        public double? MaxZoom { get; set; }

        public double? MinSize { get; set; }

        public bool? Pannable { get; set; }

        public bool? Wraparound { get; set; }

        public double? Zoom { get; set; }

        public bool? Zoomable { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Center?.Any() == true)
            {
                settings["center"] = Center;
            }

            var controls = Controls.Serialize();
            if (controls.Any())
            {
                settings["controls"] = controls;
            }

            var layerDefaults = LayerDefaults.Serialize();
            if (layerDefaults.Any())
            {
                settings["layerDefaults"] = layerDefaults;
            }

            var layers = Layers.Select(i => i.Serialize());
            if (layers.Any())
            {
                settings["layers"] = layers;
            }

            var markerDefaults = MarkerDefaults.Serialize();
            if (markerDefaults.Any())
            {
                settings["markerDefaults"] = markerDefaults;
            }

            var markers = Markers.Select(i => i.Serialize());
            if (markers.Any())
            {
                settings["markers"] = markers;
            }

            if (MinZoom.HasValue)
            {
                settings["minZoom"] = MinZoom;
            }

            if (MaxZoom.HasValue)
            {
                settings["maxZoom"] = MaxZoom;
            }

            if (MinSize.HasValue)
            {
                settings["minSize"] = MinSize;
            }

            if (Pannable.HasValue)
            {
                settings["pannable"] = Pannable;
            }

            if (Wraparound.HasValue)
            {
                settings["wraparound"] = Wraparound;
            }

            if (Zoom.HasValue)
            {
                settings["zoom"] = Zoom;
            }

            if (Zoomable.HasValue)
            {
                settings["zoomable"] = Zoomable;
            }

            return settings;
        }
    }
}
