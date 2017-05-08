using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorPasteCleanupSettings
    /// </summary>
    public partial class EditorPasteCleanupSettingsBuilder
        
    {
        public EditorPasteCleanupSettingsBuilder(EditorPasteCleanupSettings container)
        {
            Container = container;
        }

        protected EditorPasteCleanupSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
