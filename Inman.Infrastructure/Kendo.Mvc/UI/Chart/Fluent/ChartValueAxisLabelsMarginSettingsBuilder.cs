using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLabelsMarginSettings
    /// </summary>
    public partial class ChartValueAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisLabelsMarginSettingsBuilder(ChartValueAxisLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
