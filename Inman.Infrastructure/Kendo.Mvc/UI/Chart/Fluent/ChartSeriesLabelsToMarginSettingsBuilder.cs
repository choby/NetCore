using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsToMarginSettings
    /// </summary>
    public partial class ChartSeriesLabelsToMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsToMarginSettingsBuilder(ChartSeriesLabelsToMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsToMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
