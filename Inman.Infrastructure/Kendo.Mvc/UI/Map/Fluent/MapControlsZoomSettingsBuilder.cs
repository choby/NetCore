using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsZoomSettings
    /// </summary>
    public partial class MapControlsZoomSettingsBuilder
        
    {
        public MapControlsZoomSettingsBuilder(MapControlsZoomSettings container)
        {
            Container = container;
        }

        protected MapControlsZoomSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
