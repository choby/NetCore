using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsMajorGridLinesSettings
    /// </summary>
    public partial class ChartAxisDefaultsMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsMajorGridLinesSettingsBuilder(ChartAxisDefaultsMajorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsMajorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
