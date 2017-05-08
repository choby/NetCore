using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneTitleBorderSettings
    /// </summary>
    public partial class StockChartNavigatorPaneTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorPaneTitleBorderSettingsBuilder(StockChartNavigatorPaneTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorPaneTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
