using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendSettings
    /// </summary>
    public partial class ChartLegendSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendSettingsBuilder(ChartLegendSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
