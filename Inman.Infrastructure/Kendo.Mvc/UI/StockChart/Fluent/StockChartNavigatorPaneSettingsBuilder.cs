using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneSettings
    /// </summary>
    public partial class StockChartNavigatorPaneSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPaneSettingsBuilder(StockChartNavigatorPaneSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPaneSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
