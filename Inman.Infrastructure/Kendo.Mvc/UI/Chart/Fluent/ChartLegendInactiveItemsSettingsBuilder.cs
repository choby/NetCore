using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendInactiveItemsSettings
    /// </summary>
    public partial class ChartLegendInactiveItemsSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendInactiveItemsSettingsBuilder(ChartLegendInactiveItemsSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendInactiveItemsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
