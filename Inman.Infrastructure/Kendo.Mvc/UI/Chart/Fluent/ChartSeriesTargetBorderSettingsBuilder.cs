using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTargetBorderSettings
    /// </summary>
    public partial class ChartSeriesTargetBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesTargetBorderSettingsBuilder(ChartSeriesTargetBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesTargetBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
