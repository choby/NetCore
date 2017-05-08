using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsAttributionSettings
    /// </summary>
    public partial class MapControlsAttributionSettingsBuilder
        
    {
        /// <summary>
        /// Specifies the position of the attribtion control.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public MapControlsAttributionSettingsBuilder Position(MapControlPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
