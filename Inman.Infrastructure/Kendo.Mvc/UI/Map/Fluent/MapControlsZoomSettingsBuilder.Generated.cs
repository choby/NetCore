using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsZoomSettings
    /// </summary>
    public partial class MapControlsZoomSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the position of the zoom control.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public MapControlsZoomSettingsBuilder Position(MapControlPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
