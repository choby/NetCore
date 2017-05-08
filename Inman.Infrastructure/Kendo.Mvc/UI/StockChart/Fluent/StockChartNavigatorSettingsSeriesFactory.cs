using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<StockChartNavigatorSettingsSeries<T>>
    /// </summary>
    public partial class StockChartNavigatorSettingsSeriesFactory<T>
        where T : class 
    {
        public StockChartNavigatorSettingsSeriesFactory(List<StockChartNavigatorSettingsSeries<T>> container)
        {
            Container = container;
        }

        protected List<StockChartNavigatorSettingsSeries<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
