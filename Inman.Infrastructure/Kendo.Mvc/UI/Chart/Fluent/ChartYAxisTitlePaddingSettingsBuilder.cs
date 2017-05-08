using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisTitlePaddingSettings
    /// </summary>
    public partial class ChartYAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisTitlePaddingSettingsBuilder(ChartYAxisTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
