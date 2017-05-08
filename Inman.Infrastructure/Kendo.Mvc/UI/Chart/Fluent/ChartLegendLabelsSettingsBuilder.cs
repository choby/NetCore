using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendLabelsSettings
    /// </summary>
    public partial class ChartLegendLabelsSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendLabelsSettingsBuilder(ChartLegendLabelsSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
