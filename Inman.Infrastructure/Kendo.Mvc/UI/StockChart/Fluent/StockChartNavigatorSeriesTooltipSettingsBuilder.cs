using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesTooltipSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesTooltipSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesTooltipSettingsBuilder(StockChartNavigatorSeriesTooltipSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
