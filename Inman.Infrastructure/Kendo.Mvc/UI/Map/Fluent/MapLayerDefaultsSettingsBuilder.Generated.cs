using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsSettings
    /// </summary>
    public partial class MapLayerDefaultsSettingsBuilder
        
    {
        /// <summary>
        /// The default configuration for marker layers.
        /// </summary>
        /// <param name="configurator">The configurator for the marker setting.</param>
        public MapLayerDefaultsSettingsBuilder Marker(Action<MapLayerDefaultsMarkerSettingsBuilder> configurator)
        {

            Container.Marker.Map = Container.Map;
            configurator(new MapLayerDefaultsMarkerSettingsBuilder(Container.Marker));

            return this;
        }

        /// <summary>
        /// The default configuration for shape layers.
        /// </summary>
        /// <param name="configurator">The configurator for the shape setting.</param>
        public MapLayerDefaultsSettingsBuilder Shape(Action<MapLayerDefaultsShapeSettingsBuilder> configurator)
        {

            Container.Shape.Map = Container.Map;
            configurator(new MapLayerDefaultsShapeSettingsBuilder(Container.Shape));

            return this;
        }

        /// <summary>
        /// The default configuration for bubble layers.
        /// </summary>
        /// <param name="configurator">The configurator for the bubble setting.</param>
        public MapLayerDefaultsSettingsBuilder Bubble(Action<MapLayerDefaultsBubbleSettingsBuilder> configurator)
        {

            Container.Bubble.Map = Container.Map;
            configurator(new MapLayerDefaultsBubbleSettingsBuilder(Container.Bubble));

            return this;
        }

        /// <summary>
        /// The size of the image tile in pixels.
        /// </summary>
        /// <param name="value">The value for TileSize</param>
        public MapLayerDefaultsSettingsBuilder TileSize(double value)
        {
            Container.TileSize = value;
            return this;
        }

        /// <summary>
        /// The default configuration for tile layers.
        /// </summary>
        /// <param name="configurator">The configurator for the tile setting.</param>
        public MapLayerDefaultsSettingsBuilder Tile(Action<MapLayerDefaultsTileSettingsBuilder> configurator)
        {

            Container.Tile.Map = Container.Map;
            configurator(new MapLayerDefaultsTileSettingsBuilder(Container.Tile));

            return this;
        }

        /// <summary>
        /// The default configuration for Bing (tm) tile layers.
        /// </summary>
        /// <param name="configurator">The configurator for the bing setting.</param>
        public MapLayerDefaultsSettingsBuilder Bing(Action<MapLayerDefaultsBingSettingsBuilder> configurator)
        {

            Container.Bing.Map = Container.Map;
            configurator(new MapLayerDefaultsBingSettingsBuilder(Container.Bing));

            return this;
        }

    }
}
