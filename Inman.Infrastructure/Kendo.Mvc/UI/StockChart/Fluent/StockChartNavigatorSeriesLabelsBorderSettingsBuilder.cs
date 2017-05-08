using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesLabelsBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesLabelsBorderSettingsBuilder(StockChartNavigatorSeriesLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
