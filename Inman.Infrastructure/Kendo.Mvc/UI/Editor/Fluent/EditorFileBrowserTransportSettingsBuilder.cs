using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserTransportSettings
    /// </summary>
    public partial class EditorFileBrowserTransportSettingsBuilder
        
    {
        public EditorFileBrowserTransportSettingsBuilder(EditorFileBrowserTransportSettings container)
        {
            Container = container;
        }

        protected EditorFileBrowserTransportSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
