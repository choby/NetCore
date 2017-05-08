using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsFromBorderSettings
    /// </summary>
    public partial class ChartSeriesLabelsFromBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsFromBorderSettingsBuilder(ChartSeriesLabelsFromBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsFromBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
