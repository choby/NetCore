using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsSettings
    /// </summary>
    public partial class ChartAxisDefaultsSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsSettingsBuilder(ChartAxisDefaultsSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
