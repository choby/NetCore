using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTargetSettings
    /// </summary>
    public partial class ChartSeriesTargetSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesTargetSettingsBuilder(ChartSeriesTargetSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesTargetSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
