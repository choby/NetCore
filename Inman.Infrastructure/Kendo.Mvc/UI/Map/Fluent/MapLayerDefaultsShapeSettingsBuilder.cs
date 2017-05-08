using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsShapeSettings
    /// </summary>
    public partial class MapLayerDefaultsShapeSettingsBuilder
        
    {
        public MapLayerDefaultsShapeSettingsBuilder(MapLayerDefaultsShapeSettings container)
        {
            Container = container;
        }

        protected MapLayerDefaultsShapeSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
