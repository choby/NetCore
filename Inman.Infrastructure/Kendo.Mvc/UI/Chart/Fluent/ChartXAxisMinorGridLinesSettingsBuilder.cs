using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartXAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisMinorGridLinesSettingsBuilder(ChartXAxisMinorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisMinorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
