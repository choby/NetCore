using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsFromSettings
    /// </summary>
    public partial class ChartSeriesLabelsFromSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsFromSettingsBuilder(ChartSeriesLabelsFromSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsFromSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
