using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisTitleMarginSettings
    /// </summary>
    public partial class ChartCategoryAxisTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisTitleMarginSettingsBuilder(ChartCategoryAxisTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
