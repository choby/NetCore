using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLineSettings
    /// </summary>
    public partial class ChartCategoryAxisLineSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisLineSettingsBuilder(ChartCategoryAxisLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
