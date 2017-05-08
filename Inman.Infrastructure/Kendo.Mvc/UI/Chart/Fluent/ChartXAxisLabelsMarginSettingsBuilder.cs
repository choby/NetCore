using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsMarginSettings
    /// </summary>
    public partial class ChartXAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisLabelsMarginSettingsBuilder(ChartXAxisLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
