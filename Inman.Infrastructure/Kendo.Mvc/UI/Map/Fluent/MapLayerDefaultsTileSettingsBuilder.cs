using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsTileSettings
    /// </summary>
    public partial class MapLayerDefaultsTileSettingsBuilder
        
    {
        public MapLayerDefaultsTileSettingsBuilder(MapLayerDefaultsTileSettings container)
        {
            Container = container;
        }

        protected MapLayerDefaultsTileSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
