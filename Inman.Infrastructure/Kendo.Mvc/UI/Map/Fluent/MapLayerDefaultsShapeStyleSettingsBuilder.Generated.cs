using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsShapeStyleSettings
    /// </summary>
    public partial class MapLayerDefaultsShapeStyleSettingsBuilder
        
    {
        /// <summary>
        /// The default fill for layer shapes.
		/// Accepts a valid CSS color string or object with detailed configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the fill setting.</param>
        public MapLayerDefaultsShapeStyleSettingsBuilder Fill(Action<MapLayerDefaultsShapeStyleFillSettingsBuilder> configurator)
        {

            Container.Fill.Map = Container.Map;
            configurator(new MapLayerDefaultsShapeStyleFillSettingsBuilder(Container.Fill));

            return this;
        }

        /// <summary>
        /// The default stroke for layer shapes.
		/// Accepts a valid CSS color string or object with detailed configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the stroke setting.</param>
        public MapLayerDefaultsShapeStyleSettingsBuilder Stroke(Action<MapLayerDefaultsShapeStyleStrokeSettingsBuilder> configurator)
        {

            Container.Stroke.Map = Container.Map;
            configurator(new MapLayerDefaultsShapeStyleStrokeSettingsBuilder(Container.Stroke));

            return this;
        }

    }
}
