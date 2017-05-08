using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBubbleStyleSettings
    /// </summary>
    public partial class MapLayerDefaultsBubbleStyleSettingsBuilder
        
    {
        /// <summary>
        /// The default fill for bubble layer symbols.
		/// Accepts a valid CSS color string or object with detailed configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the fill setting.</param>
        public MapLayerDefaultsBubbleStyleSettingsBuilder Fill(Action<MapLayerDefaultsBubbleStyleFillSettingsBuilder> configurator)
        {

            Container.Fill.Map = Container.Map;
            configurator(new MapLayerDefaultsBubbleStyleFillSettingsBuilder(Container.Fill));

            return this;
        }

        /// <summary>
        /// The default stroke for bubble layer symbols.
		/// Accepts a valid CSS color string or object with detailed configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the stroke setting.</param>
        public MapLayerDefaultsBubbleStyleSettingsBuilder Stroke(Action<MapLayerDefaultsBubbleStyleStrokeSettingsBuilder> configurator)
        {

            Container.Stroke.Map = Container.Map;
            configurator(new MapLayerDefaultsBubbleStyleStrokeSettingsBuilder(Container.Stroke));

            return this;
        }

    }
}
