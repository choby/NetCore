using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsMarginSettings
    /// </summary>
    public partial class ChartSeriesLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsMarginSettingsBuilder(ChartSeriesLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
