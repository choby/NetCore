using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSelectSettings
    /// </summary>
    public partial class StockChartNavigatorSelectSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSelectSettingsBuilder(StockChartNavigatorSelectSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSelectSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
