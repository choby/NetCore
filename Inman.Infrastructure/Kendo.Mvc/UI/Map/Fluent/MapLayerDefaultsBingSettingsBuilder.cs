using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBingSettings
    /// </summary>
    public partial class MapLayerDefaultsBingSettingsBuilder
        
    {
        public MapLayerDefaultsBingSettingsBuilder(MapLayerDefaultsBingSettings container)
        {
            Container = container;
        }

        protected MapLayerDefaultsBingSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
