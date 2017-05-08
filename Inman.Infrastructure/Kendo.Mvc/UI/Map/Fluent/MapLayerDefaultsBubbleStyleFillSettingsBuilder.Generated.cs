using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBubbleStyleFillSettings
    /// </summary>
    public partial class MapLayerDefaultsBubbleStyleFillSettingsBuilder
        
    {
        /// <summary>
        /// The default fill color for bubble layer symbols.
		/// Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public MapLayerDefaultsBubbleStyleFillSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The default fill opacity (0 to 1) for layer symbols.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsBubbleStyleFillSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

    }
}
