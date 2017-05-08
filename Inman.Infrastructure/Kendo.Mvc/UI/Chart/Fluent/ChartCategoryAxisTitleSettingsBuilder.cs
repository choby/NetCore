using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisTitleSettings
    /// </summary>
    public partial class ChartCategoryAxisTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisTitleSettingsBuilder(ChartCategoryAxisTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
