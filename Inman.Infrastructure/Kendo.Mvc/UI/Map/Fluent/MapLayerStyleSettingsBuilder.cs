using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerStyleSettings
    /// </summary>
    public partial class MapLayerStyleSettingsBuilder
        
    {
        public MapLayerStyleSettingsBuilder(MapLayerStyleSettings container)
        {
            Container = container;
        }

        protected MapLayerStyleSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
