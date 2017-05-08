using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartYAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisMinorGridLinesSettingsBuilder(ChartYAxisMinorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisMinorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
