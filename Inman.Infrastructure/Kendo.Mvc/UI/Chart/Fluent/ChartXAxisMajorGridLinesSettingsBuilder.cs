using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisMajorGridLinesSettings
    /// </summary>
    public partial class ChartXAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisMajorGridLinesSettingsBuilder(ChartXAxisMajorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisMajorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
