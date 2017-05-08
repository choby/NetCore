using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBubbleStyleStrokeSettings
    /// </summary>
    public partial class MapLayerDefaultsBubbleStyleStrokeSettingsBuilder
        
    {
        /// <summary>
        /// The default stroke color for bubble layer symbols.
		/// Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The default dash type for layer symbols.
		/// The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder DashType(string value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The default stroke opacity (0 to 1) for bubble layer symbols.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The default stroke width for bubble layer symbols.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public MapLayerDefaultsBubbleStyleStrokeSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
