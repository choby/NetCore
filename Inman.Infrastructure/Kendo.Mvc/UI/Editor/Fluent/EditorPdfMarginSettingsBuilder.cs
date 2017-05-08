using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorPdfMarginSettings
    /// </summary>
    public partial class EditorPdfMarginSettingsBuilder
        
    {
        public EditorPdfMarginSettingsBuilder(EditorPdfMarginSettings container)
        {
            Container = container;
        }

        protected EditorPdfMarginSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
