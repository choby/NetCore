using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<MapLayer>
    /// </summary>
    public partial class MapLayerFactory
        
    {
        public MapLayerFactory(List<MapLayer> container)
        {
            Container = container;
        }

        protected List<MapLayer> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
