using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsShapeStyleStrokeSettings
    /// </summary>
    public partial class MapLayerDefaultsShapeStyleStrokeSettingsBuilder
        
    {
        /// <summary>
        /// The default stroke color for layer shapes.
		/// Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public MapLayerDefaultsShapeStyleStrokeSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The default dash type for layer shapes.
		/// The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public MapLayerDefaultsShapeStyleStrokeSettingsBuilder DashType(string value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The default stroke opacity (0 to 1) for layer shapes.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsShapeStyleStrokeSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The default stroke width for layer shapes.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public MapLayerDefaultsShapeStyleStrokeSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
