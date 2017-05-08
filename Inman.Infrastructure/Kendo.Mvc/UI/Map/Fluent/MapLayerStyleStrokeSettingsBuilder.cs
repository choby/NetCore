using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerStyleStrokeSettings
    /// </summary>
    public partial class MapLayerStyleStrokeSettingsBuilder
        
    {
        public MapLayerStyleStrokeSettingsBuilder(MapLayerStyleStrokeSettings container)
        {
            Container = container;
        }

        protected MapLayerStyleStrokeSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
