using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTitlePaddingSettings
    /// </summary>
    public partial class ChartTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartTitlePaddingSettingsBuilder(ChartTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
