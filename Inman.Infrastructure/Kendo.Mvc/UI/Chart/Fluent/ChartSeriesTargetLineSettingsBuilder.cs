using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTargetLineSettings
    /// </summary>
    public partial class ChartSeriesTargetLineSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesTargetLineSettingsBuilder(ChartSeriesTargetLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesTargetLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
