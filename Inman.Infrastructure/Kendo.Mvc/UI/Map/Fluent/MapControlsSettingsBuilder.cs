using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapControlsSettings
    /// </summary>
    public partial class MapControlsSettingsBuilder
        
    {
        public MapControlsSettingsBuilder(MapControlsSettings container)
        {
            Container = container;
        }

        protected MapControlsSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
