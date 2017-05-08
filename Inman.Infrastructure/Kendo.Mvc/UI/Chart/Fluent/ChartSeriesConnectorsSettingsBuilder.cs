using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesConnectorsSettings
    /// </summary>
    public partial class ChartSeriesConnectorsSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesConnectorsSettingsBuilder(ChartSeriesConnectorsSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesConnectorsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
