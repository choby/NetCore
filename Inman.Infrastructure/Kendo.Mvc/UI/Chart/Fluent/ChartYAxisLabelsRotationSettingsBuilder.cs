using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartYAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisLabelsRotationSettingsBuilder(ChartYAxisLabelsRotationSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisLabelsRotationSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
