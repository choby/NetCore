using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPanePaddingSettings
    /// </summary>
    public partial class StockChartNavigatorPanePaddingSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPanePaddingSettingsBuilder(StockChartNavigatorPanePaddingSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPanePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
