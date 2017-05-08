using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisTitleBorderSettings
    /// </summary>
    public partial class ChartCategoryAxisTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisTitleBorderSettingsBuilder(ChartCategoryAxisTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
