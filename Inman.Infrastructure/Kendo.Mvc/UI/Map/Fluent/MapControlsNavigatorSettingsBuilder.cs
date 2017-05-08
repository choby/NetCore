using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsNavigatorSettings
    /// </summary>
    public partial class MapControlsNavigatorSettingsBuilder
        
    {
        public MapControlsNavigatorSettingsBuilder(MapControlsNavigatorSettings container)
        {
            Container = container;
        }

        protected MapControlsNavigatorSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
