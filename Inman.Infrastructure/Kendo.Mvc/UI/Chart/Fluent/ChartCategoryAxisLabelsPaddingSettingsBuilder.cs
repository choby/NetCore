using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsPaddingSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisLabelsPaddingSettingsBuilder(ChartCategoryAxisLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
