using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsMarkerSettings
    /// </summary>
    public partial class MapLayerDefaultsMarkerSettingsBuilder
        
    {
        /// <summary>
        /// The the opacity of all marker layers.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsMarkerSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The marker shape. Supported shapes are "pin" and "pinTarget".
        /// </summary>
        /// <param name="value">The value for Shape</param>
        public MapLayerDefaultsMarkerSettingsBuilder Shape(MapMarkersShape value)
        {
            Container.Shape = value;
            return this;
        }

    }
}
