using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsRotationSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisLabelsRotationSettingsBuilder(ChartCategoryAxisLabelsRotationSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisLabelsRotationSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
