using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserTransportSettings
    /// </summary>
    public partial class EditorImageBrowserTransportSettingsBuilder
        
    {
        public EditorImageBrowserTransportSettingsBuilder(EditorImageBrowserTransportSettings container)
        {
            Container = container;
        }

        protected EditorImageBrowserTransportSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
