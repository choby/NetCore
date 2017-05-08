using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsShapeSettings
    /// </summary>
    public partial class MapLayerDefaultsShapeSettingsBuilder
        
    {
        /// <summary>
        /// The attribution for all shape layers.
        /// </summary>
        /// <param name="value">The value for Attribution</param>
        public MapLayerDefaultsShapeSettingsBuilder Attribution(string value)
        {
            Container.Attribution = value;
            return this;
        }

        /// <summary>
        /// The the opacity of all shape layers.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsShapeSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The default style for shapes.
        /// </summary>
        /// <param name="configurator">The configurator for the style setting.</param>
        public MapLayerDefaultsShapeSettingsBuilder Style(Action<MapLayerDefaultsShapeStyleSettingsBuilder> configurator)
        {

            Container.Style.Map = Container.Map;
            configurator(new MapLayerDefaultsShapeStyleSettingsBuilder(Container.Style));

            return this;
        }

    }
}
