using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerStyleSettings
    /// </summary>
    public partial class MapLayerStyleSettingsBuilder
        
    {
        /// <summary>
        /// The default fill for layer shapes.
		/// Accepts a valid CSS color string or object with detailed configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the fill setting.</param>
        public MapLayerStyleSettingsBuilder Fill(Action<MapLayerStyleFillSettingsBuilder> configurator)
        {

            Container.Fill.Map = Container.Map;
            configurator(new MapLayerStyleFillSettingsBuilder(Container.Fill));

            return this;
        }

        /// <summary>
        /// The default stroke for layer shapes.
		/// Accepts a valid CSS color string or object with detailed configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the stroke setting.</param>
        public MapLayerStyleSettingsBuilder Stroke(Action<MapLayerStyleStrokeSettingsBuilder> configurator)
        {

            Container.Stroke.Map = Container.Map;
            configurator(new MapLayerStyleStrokeSettingsBuilder(Container.Stroke));

            return this;
        }

    }
}
