using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisTitleMarginSettings
    /// </summary>
    public partial class ChartXAxisTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisTitleMarginSettingsBuilder(ChartXAxisTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
