using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Map
    /// </summary>
    public partial class MapBuilder
        
    {
        /// <summary>
        /// The map center. Coordinates are listed as [Latitude, Longitude].
        /// </summary>
        /// <param name="value">The value for Center</param>
        public MapBuilder Center(params double[] value)
        {
            Container.Center = value;
            return this;
        }

        /// <summary>
        /// The configuration of built-in map controls.
        /// </summary>
        /// <param name="configurator">The configurator for the controls setting.</param>
        public MapBuilder Controls(Action<MapControlsSettingsBuilder> configurator)
        {

            Container.Controls.Map = Container;
            configurator(new MapControlsSettingsBuilder(Container.Controls));

            return this;
        }

        /// <summary>
        /// The default configuration for map layers by type.
        /// </summary>
        /// <param name="configurator">The configurator for the layerdefaults setting.</param>
        public MapBuilder LayerDefaults(Action<MapLayerDefaultsSettingsBuilder> configurator)
        {

            Container.LayerDefaults.Map = Container;
            configurator(new MapLayerDefaultsSettingsBuilder(Container.LayerDefaults));

            return this;
        }

        /// <summary>
        /// The configuration of the map layers.
		/// The layer type is determined by the value of the type field.
        /// </summary>
        /// <param name="configurator">The configurator for the layers setting.</param>
        public MapBuilder Layers(Action<MapLayerFactory> configurator)
        {

            configurator(new MapLayerFactory(Container.Layers)
            {
                Map = Container
            });

            return this;
        }

        /// <summary>
        /// The default options for all markers.
        /// </summary>
        /// <param name="configurator">The configurator for the markerdefaults setting.</param>
        public MapBuilder MarkerDefaults(Action<MapMarkerDefaultsSettingsBuilder> configurator)
        {

            Container.MarkerDefaults.Map = Container;
            configurator(new MapMarkerDefaultsSettingsBuilder(Container.MarkerDefaults));

            return this;
        }

        /// <summary>
        /// Static markers to display on the map.
        /// </summary>
        /// <param name="configurator">The configurator for the markers setting.</param>
        public MapBuilder Markers(Action<MapMarkerFactory> configurator)
        {

            configurator(new MapMarkerFactory(Container.Markers)
            {
                Map = Container
            });

            return this;
        }

        /// <summary>
        /// The minimum zoom level.
		/// Typical web maps use zoom levels from 0 (whole world) to 19 (sub-meter features).
        /// </summary>
        /// <param name="value">The value for MinZoom</param>
        public MapBuilder MinZoom(double value)
        {
            Container.MinZoom = value;
            return this;
        }

        /// <summary>
        /// The maximum zoom level.
		/// Typical web maps use zoom levels from 0 (whole world) to 19 (sub-meter features).
        /// </summary>
        /// <param name="value">The value for MaxZoom</param>
        public MapBuilder MaxZoom(double value)
        {
            Container.MaxZoom = value;
            return this;
        }

        /// <summary>
        /// The size of the map in pixels at zoom level 0.
        /// </summary>
        /// <param name="value">The value for MinSize</param>
        public MapBuilder MinSize(double value)
        {
            Container.MinSize = value;
            return this;
        }

        /// <summary>
        /// Controls whether the user can pan the map.
        /// </summary>
        /// <param name="value">The value for Pannable</param>
        public MapBuilder Pannable(bool value)
        {
            Container.Pannable = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the map should wrap around the east-west edges.
        /// </summary>
        /// <param name="value">The value for Wraparound</param>
        public MapBuilder Wraparound(bool value)
        {
            Container.Wraparound = value;
            return this;
        }

        /// <summary>
        /// The initial zoom level.Typical web maps use zoom levels from 0 (whole world) to 19 (sub-meter features).The map size is derived from the zoom level and minScale options: size = (2 ^ zoom) * minSize
        /// </summary>
        /// <param name="value">The value for Zoom</param>
        public MapBuilder Zoom(double value)
        {
            Container.Zoom = value;
            return this;
        }

        /// <summary>
        /// Controls whether the map zoom level can be changed by the user.
        /// </summary>
        /// <param name="value">The value for Zoomable</param>
        public MapBuilder Zoomable(bool value)
        {
            Container.Zoomable = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Map()
        ///       .Name("Map")
        ///       .Events(events => events
        ///           .BeforeReset("onBeforeReset")
        ///       )
        /// )
        /// </code>
        /// </example>
        public MapBuilder Events(Action<MapEventBuilder> configurator)
        {
            configurator(new MapEventBuilder(Container.Events));
            return this;
        }
        
    }
}

