using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneTitleSettings
    /// </summary>
    public partial class StockChartNavigatorPaneTitleSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPaneTitleSettingsBuilder(StockChartNavigatorPaneTitleSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPaneTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
