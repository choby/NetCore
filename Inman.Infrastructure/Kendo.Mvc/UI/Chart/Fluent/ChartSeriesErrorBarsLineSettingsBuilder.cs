using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesErrorBarsLineSettings
    /// </summary>
    public partial class ChartSeriesErrorBarsLineSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesErrorBarsLineSettingsBuilder(ChartSeriesErrorBarsLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesErrorBarsLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
