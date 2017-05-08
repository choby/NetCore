using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisSelectSettings
    /// </summary>
    public partial class ChartCategoryAxisSelectSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisSelectSettingsBuilder(ChartCategoryAxisSelectSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisSelectSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
