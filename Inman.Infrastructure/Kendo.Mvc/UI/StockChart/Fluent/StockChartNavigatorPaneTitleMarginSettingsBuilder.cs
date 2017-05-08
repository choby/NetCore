using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneTitleMarginSettings
    /// </summary>
    public partial class StockChartNavigatorPaneTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPaneTitleMarginSettingsBuilder(StockChartNavigatorPaneTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPaneTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
