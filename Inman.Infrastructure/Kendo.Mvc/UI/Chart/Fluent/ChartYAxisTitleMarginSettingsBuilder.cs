using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisTitleMarginSettings
    /// </summary>
    public partial class ChartYAxisTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisTitleMarginSettingsBuilder(ChartYAxisTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
