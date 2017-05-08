using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisTitleSettings
    /// </summary>
    public partial class ChartYAxisTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisTitleSettingsBuilder(ChartYAxisTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
