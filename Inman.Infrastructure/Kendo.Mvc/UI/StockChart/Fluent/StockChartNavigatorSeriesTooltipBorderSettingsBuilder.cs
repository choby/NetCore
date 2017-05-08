using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesTooltipBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesTooltipBorderSettingsBuilder(StockChartNavigatorSeriesTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
