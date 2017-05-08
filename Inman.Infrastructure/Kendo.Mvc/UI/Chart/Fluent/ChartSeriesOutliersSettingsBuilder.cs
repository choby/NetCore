using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesOutliersSettings
    /// </summary>
    public partial class ChartSeriesOutliersSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesOutliersSettingsBuilder(ChartSeriesOutliersSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesOutliersSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
