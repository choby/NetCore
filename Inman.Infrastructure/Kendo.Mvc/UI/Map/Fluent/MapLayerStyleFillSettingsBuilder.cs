using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerStyleFillSettings
    /// </summary>
    public partial class MapLayerStyleFillSettingsBuilder
        
    {
        public MapLayerStyleFillSettingsBuilder(MapLayerStyleFillSettings container)
        {
            Container = container;
        }

        protected MapLayerStyleFillSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
