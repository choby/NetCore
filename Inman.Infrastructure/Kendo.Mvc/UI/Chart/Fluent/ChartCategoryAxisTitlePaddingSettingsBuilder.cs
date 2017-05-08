using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisTitlePaddingSettings
    /// </summary>
    public partial class ChartCategoryAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisTitlePaddingSettingsBuilder(ChartCategoryAxisTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
