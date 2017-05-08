using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsMarginSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisLabelsMarginSettingsBuilder(ChartCategoryAxisLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
