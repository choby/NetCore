using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsFromPaddingSettings
    /// </summary>
    public partial class ChartSeriesLabelsFromPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsFromPaddingSettingsBuilder(ChartSeriesLabelsFromPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsFromPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
