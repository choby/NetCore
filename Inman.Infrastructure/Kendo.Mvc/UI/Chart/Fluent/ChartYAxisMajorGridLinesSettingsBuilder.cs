using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisMajorGridLinesSettings
    /// </summary>
    public partial class ChartYAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisMajorGridLinesSettingsBuilder(ChartYAxisMajorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisMajorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
