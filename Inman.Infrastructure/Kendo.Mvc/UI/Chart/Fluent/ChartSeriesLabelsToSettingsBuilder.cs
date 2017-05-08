using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsToSettings
    /// </summary>
    public partial class ChartSeriesLabelsToSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsToSettingsBuilder(ChartSeriesLabelsToSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsToSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
