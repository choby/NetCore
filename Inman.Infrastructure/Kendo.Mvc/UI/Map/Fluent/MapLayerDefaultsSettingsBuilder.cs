using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsSettings
    /// </summary>
    public partial class MapLayerDefaultsSettingsBuilder
        
    {
        public MapLayerDefaultsSettingsBuilder(MapLayerDefaultsSettings container)
        {
            Container = container;
        }

        protected MapLayerDefaultsSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
