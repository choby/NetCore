using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSettingsSeries
    /// </summary>
    public partial class StockChartNavigatorSettingsSeriesBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSettingsSeriesBuilder(StockChartNavigatorSettingsSeries<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSettingsSeries<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
