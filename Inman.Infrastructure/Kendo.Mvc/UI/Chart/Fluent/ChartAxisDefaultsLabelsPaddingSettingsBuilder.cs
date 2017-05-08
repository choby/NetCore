using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsLabelsPaddingSettings
    /// </summary>
    public partial class ChartAxisDefaultsLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsLabelsPaddingSettingsBuilder(ChartAxisDefaultsLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
