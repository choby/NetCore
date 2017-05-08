using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisTitlePaddingSettings
    /// </summary>
    public partial class ChartXAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisTitlePaddingSettingsBuilder(ChartXAxisTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
