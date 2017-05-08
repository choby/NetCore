using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsShapeStyleFillSettings
    /// </summary>
    public partial class MapLayerDefaultsShapeStyleFillSettingsBuilder
        
    {
        /// <summary>
        /// The default fill color for layer shapes.
		/// Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public MapLayerDefaultsShapeStyleFillSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The default fill opacity (0 to 1) for layer shapes.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsShapeStyleFillSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

    }
}
