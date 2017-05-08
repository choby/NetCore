using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartValueAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisLabelsRotationSettingsBuilder(ChartValueAxisLabelsRotationSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisLabelsRotationSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
