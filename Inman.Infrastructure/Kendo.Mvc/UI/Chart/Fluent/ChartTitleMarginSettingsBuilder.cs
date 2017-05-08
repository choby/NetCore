using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTitleMarginSettings
    /// </summary>
    public partial class ChartTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartTitleMarginSettingsBuilder(ChartTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
