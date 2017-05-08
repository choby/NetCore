using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapMarker
    /// </summary>
    public partial class MapMarkerBuilder
        
    {
        /// <summary>
        /// The marker location on the map. Coordinates are listed as [Latitude, Longitude].
        /// </summary>
        /// <param name="value">The value for Location</param>
        public MapMarkerBuilder Location(params double[] value)
        {
            Container.Location = value;
            return this;
        }

        /// <summary>
        /// The marker title. Displayed as browser tooltip.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public MapMarkerBuilder Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// The marker shape. Supported shapes are "pin" and "pinTarget".
        /// </summary>
        /// <param name="value">The value for Shape</param>
        public MapMarkerBuilder Shape(MapMarkersShape value)
        {
            Container.Shape = value;
            return this;
        }

    }
}
