using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotGridPdfMarginSettings
    /// </summary>
    public partial class PivotGridPdfMarginSettingsBuilder<T>
        where T : class 
    {
        public PivotGridPdfMarginSettingsBuilder(PivotGridPdfMarginSettings<T> container)
        {
            Container = container;
        }

        protected PivotGridPdfMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
