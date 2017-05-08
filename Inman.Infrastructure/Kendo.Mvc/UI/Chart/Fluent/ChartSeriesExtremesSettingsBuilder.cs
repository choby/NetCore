using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesExtremesSettings
    /// </summary>
    public partial class ChartSeriesExtremesSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesExtremesSettingsBuilder(ChartSeriesExtremesSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesExtremesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
