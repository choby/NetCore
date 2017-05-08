using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorHintSettings
    /// </summary>
    public partial class StockChartNavigatorHintSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorHintSettingsBuilder(StockChartNavigatorHintSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorHintSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
