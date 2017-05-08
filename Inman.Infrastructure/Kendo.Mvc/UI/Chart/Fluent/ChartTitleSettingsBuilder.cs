using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTitleSettings
    /// </summary>
    public partial class ChartTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartTitleSettingsBuilder(ChartTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
