using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesErrorBarsSettings
    /// </summary>
    public partial class ChartSeriesErrorBarsSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesErrorBarsSettingsBuilder(ChartSeriesErrorBarsSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesErrorBarsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
