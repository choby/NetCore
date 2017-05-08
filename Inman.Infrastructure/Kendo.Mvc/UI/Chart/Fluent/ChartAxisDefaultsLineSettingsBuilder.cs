using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsLineSettings
    /// </summary>
    public partial class ChartAxisDefaultsLineSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsLineSettingsBuilder(ChartAxisDefaultsLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
