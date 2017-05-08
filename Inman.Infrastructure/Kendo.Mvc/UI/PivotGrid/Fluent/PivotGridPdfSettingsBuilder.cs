using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotGridPdfSettings
    /// </summary>
    public partial class PivotGridPdfSettingsBuilder<T>
        where T : class 
    {
        public PivotGridPdfSettingsBuilder(PivotGridPdfSettings<T> container)
        {
            Container = container;
        }

        protected PivotGridPdfSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
