using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneMarginSettings
    /// </summary>
    public partial class ChartPaneMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartPaneMarginSettingsBuilder(ChartPaneMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartPaneMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
