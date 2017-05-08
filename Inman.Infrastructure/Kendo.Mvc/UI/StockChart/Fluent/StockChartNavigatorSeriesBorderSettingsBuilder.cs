using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesBorderSettingsBuilder(StockChartNavigatorSeriesBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
