using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesMarginSettings
    /// </summary>
    public partial class ChartSeriesMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesMarginSettingsBuilder(ChartSeriesMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
