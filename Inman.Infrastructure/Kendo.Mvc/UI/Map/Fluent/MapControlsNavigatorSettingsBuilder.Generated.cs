using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsNavigatorSettings
    /// </summary>
    public partial class MapControlsNavigatorSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the position of the navigation control.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public MapControlsNavigatorSettingsBuilder Position(MapControlPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
