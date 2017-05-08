using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListPdfSettings
    /// </summary>
    public partial class TreeListPdfSettingsBuilder<T> : PdfSettingsBuilder<TreeListPdfSettingsBuilder<T>>

	{
        public TreeListPdfSettingsBuilder(TreeListPdfSettings<T> container) : base (container)
        {
            Container = container;
        }

        protected TreeListPdfSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
