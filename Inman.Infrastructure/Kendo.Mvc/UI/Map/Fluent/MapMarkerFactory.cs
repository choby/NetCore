using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<MapMarker>
    /// </summary>
    public partial class MapMarkerFactory
        
    {
        public MapMarkerFactory(List<MapMarker> container)
        {
            Container = container;
        }

        protected List<MapMarker> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
