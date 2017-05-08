using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserSchemaSettings
    /// </summary>
    public partial class EditorImageBrowserSchemaSettingsBuilder
        
    {
        public EditorImageBrowserSchemaSettingsBuilder(EditorImageBrowserSchemaSettings container)
        {
            Container = container;
        }

        protected EditorImageBrowserSchemaSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
