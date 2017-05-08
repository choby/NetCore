using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorResizableSettings
    /// </summary>
    public partial class EditorResizableSettingsBuilder
        
    {
        public EditorResizableSettingsBuilder(EditorResizableSettings container)
        {
            Container = container;
        }

        protected EditorResizableSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
