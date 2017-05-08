using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsLabelsSettings
    /// </summary>
    public partial class ChartAxisDefaultsLabelsSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsLabelsSettingsBuilder(ChartAxisDefaultsLabelsSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
