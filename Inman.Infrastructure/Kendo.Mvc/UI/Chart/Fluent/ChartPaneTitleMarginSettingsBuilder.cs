using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneTitleMarginSettings
    /// </summary>
    public partial class ChartPaneTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartPaneTitleMarginSettingsBuilder(ChartPaneTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartPaneTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
