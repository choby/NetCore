using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendItemSettings
    /// </summary>
    public partial class ChartLegendItemSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendItemSettingsBuilder(ChartLegendItemSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendItemSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
