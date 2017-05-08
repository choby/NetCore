using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridPdfSettings
    /// </summary>
    public partial class GridPdfSettingsBuilder<T> : PdfSettingsBuilder<GridPdfSettingsBuilder<T>>
        
    {
        public GridPdfSettingsBuilder(GridPdfSettings<T> container) : base (container)
        {
            Container = container;
        }

        protected GridPdfSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
