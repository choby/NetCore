using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisTitleSettings
    /// </summary>
    public partial class ChartValueAxisTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisTitleSettingsBuilder(ChartValueAxisTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
