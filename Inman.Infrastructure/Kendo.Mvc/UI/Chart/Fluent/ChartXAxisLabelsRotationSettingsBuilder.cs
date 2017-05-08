using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartXAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisLabelsRotationSettingsBuilder(ChartXAxisLabelsRotationSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisLabelsRotationSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
