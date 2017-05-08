using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorPdfSettings
    /// </summary>
    public partial class EditorPdfSettingsBuilder : PdfSettingsBuilder<EditorPdfSettingsBuilder>
        
    {
        public EditorPdfSettingsBuilder(EditorPdfSettings container): base (container)
        {
            Container = container;
        }

        protected EditorPdfSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
