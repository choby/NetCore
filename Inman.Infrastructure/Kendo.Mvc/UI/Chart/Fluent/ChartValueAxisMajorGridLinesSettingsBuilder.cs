using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMajorGridLinesSettings
    /// </summary>
    public partial class ChartValueAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisMajorGridLinesSettingsBuilder(ChartValueAxisMajorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisMajorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
