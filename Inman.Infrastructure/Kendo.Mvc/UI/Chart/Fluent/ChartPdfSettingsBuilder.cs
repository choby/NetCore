using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPdfSettings
    /// </summary>
    public partial class ChartPdfSettingsBuilder<T>
        where T : class 
    {
        public ChartPdfSettingsBuilder(ChartPdfSettings<T> container)
        {
            Container = container;
        }

        protected ChartPdfSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
