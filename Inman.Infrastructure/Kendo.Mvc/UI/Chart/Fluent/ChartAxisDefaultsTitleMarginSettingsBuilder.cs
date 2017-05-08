using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsTitleMarginSettings
    /// </summary>
    public partial class ChartAxisDefaultsTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsTitleMarginSettingsBuilder(ChartAxisDefaultsTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
