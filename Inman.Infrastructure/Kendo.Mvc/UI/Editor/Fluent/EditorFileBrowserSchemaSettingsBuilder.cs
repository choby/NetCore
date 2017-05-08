using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSchemaSettings
    /// </summary>
    public partial class EditorFileBrowserSchemaSettingsBuilder
        
    {
        public EditorFileBrowserSchemaSettingsBuilder(EditorFileBrowserSchemaSettings container)
        {
            Container = container;
        }

        protected EditorFileBrowserSchemaSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
