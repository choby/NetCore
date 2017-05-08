using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapMarkerDefaultsSettings
    /// </summary>
    public partial class MapMarkerDefaultsSettingsBuilder
        
    {
        /// <summary>
        /// The default marker shape. Supported shapes are "pin" and "pinTarget".
        /// </summary>
        /// <param name="value">The value for Shape</param>
        public MapMarkerDefaultsSettingsBuilder Shape(MapMarkersShape value)
        {
            Container.Shape = value;
            return this;
        }

    }
}
