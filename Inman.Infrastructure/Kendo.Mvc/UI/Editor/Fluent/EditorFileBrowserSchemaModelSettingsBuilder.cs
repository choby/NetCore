using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSchemaModelSettings
    /// </summary>
    public partial class EditorFileBrowserSchemaModelSettingsBuilder
        
    {
        public EditorFileBrowserSchemaModelSettingsBuilder(EditorFileBrowserSchemaModelSettings container)
        {
            Container = container;
        }

        protected EditorFileBrowserSchemaModelSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
