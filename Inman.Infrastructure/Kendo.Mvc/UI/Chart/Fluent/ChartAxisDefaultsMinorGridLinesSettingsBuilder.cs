using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsMinorGridLinesSettings
    /// </summary>
    public partial class ChartAxisDefaultsMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsMinorGridLinesSettingsBuilder(ChartAxisDefaultsMinorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsMinorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
