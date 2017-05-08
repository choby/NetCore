using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneBorderSettings
    /// </summary>
    public partial class StockChartNavigatorPaneBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPaneBorderSettingsBuilder(StockChartNavigatorPaneBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPaneBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
