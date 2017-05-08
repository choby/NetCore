using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisTitleSettings
    /// </summary>
    public partial class ChartXAxisTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisTitleSettingsBuilder(ChartXAxisTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
