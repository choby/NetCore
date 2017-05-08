using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesStackSettings
    /// </summary>
    public partial class ChartSeriesStackSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesStackSettingsBuilder(ChartSeriesStackSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesStackSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
