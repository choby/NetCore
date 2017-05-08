using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsAttributionSettings
    /// </summary>
    public partial class MapControlsAttributionSettingsBuilder
        
    {
        public MapControlsAttributionSettingsBuilder(MapControlsAttributionSettings container)
        {
            Container = container;
        }

        protected MapControlsAttributionSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
