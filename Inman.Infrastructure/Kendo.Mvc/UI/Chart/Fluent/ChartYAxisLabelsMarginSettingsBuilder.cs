using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsMarginSettings
    /// </summary>
    public partial class ChartYAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisLabelsMarginSettingsBuilder(ChartYAxisLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
