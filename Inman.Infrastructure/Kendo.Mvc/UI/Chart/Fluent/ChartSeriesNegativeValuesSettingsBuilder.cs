using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNegativeValuesSettings
    /// </summary>
    public partial class ChartSeriesNegativeValuesSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNegativeValuesSettingsBuilder(ChartSeriesNegativeValuesSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNegativeValuesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
