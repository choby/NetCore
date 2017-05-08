using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsDateFormatsSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsDateFormatsSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisLabelsDateFormatsSettingsBuilder(ChartCategoryAxisLabelsDateFormatsSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisLabelsDateFormatsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
