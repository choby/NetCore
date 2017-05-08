using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsLabelsMarginSettings
    /// </summary>
    public partial class ChartAxisDefaultsLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsLabelsMarginSettingsBuilder(ChartAxisDefaultsLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
