using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerStyleFillSettings
    /// </summary>
    public partial class MapLayerStyleFillSettingsBuilder
        
    {
        /// <summary>
        /// The default fill color for layer shapes.
		/// Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public MapLayerStyleFillSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The default fill opacity (0 to 1) for layer shapes.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerStyleFillSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

    }
}
