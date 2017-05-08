using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisTitleMarginSettings
    /// </summary>
    public partial class ChartValueAxisTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisTitleMarginSettingsBuilder(ChartValueAxisTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
