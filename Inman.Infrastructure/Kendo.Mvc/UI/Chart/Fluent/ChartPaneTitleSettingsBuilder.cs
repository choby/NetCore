using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneTitleSettings
    /// </summary>
    public partial class ChartPaneTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartPaneTitleSettingsBuilder(ChartPaneTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartPaneTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
