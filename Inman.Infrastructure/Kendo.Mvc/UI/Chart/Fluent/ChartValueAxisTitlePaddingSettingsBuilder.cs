using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisTitlePaddingSettings
    /// </summary>
    public partial class ChartValueAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisTitlePaddingSettingsBuilder(ChartValueAxisTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
