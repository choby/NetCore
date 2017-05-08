using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsFromMarginSettings
    /// </summary>
    public partial class ChartSeriesLabelsFromMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsFromMarginSettingsBuilder(ChartSeriesLabelsFromMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsFromMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
