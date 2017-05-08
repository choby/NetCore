using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartValueAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisMinorGridLinesSettingsBuilder(ChartValueAxisMinorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisMinorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
