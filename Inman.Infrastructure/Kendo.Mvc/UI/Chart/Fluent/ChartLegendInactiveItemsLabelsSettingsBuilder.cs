using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendInactiveItemsLabelsSettings
    /// </summary>
    public partial class ChartLegendInactiveItemsLabelsSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendInactiveItemsLabelsSettingsBuilder(ChartLegendInactiveItemsLabelsSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendInactiveItemsLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
