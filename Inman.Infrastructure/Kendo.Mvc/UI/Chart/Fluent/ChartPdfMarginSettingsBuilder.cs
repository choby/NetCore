using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPdfMarginSettings
    /// </summary>
    public partial class ChartPdfMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartPdfMarginSettingsBuilder(ChartPdfMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartPdfMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
