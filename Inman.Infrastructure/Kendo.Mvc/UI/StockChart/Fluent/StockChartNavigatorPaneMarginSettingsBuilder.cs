using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneMarginSettings
    /// </summary>
    public partial class StockChartNavigatorPaneMarginSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPaneMarginSettingsBuilder(StockChartNavigatorPaneMarginSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPaneMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
