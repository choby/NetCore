using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsMinorTicksSettings
    /// </summary>
    public partial class ChartAxisDefaultsMinorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsMinorTicksSettingsBuilder(ChartAxisDefaultsMinorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsMinorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
