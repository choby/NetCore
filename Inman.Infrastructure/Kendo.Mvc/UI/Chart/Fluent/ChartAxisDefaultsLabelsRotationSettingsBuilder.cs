using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsLabelsRotationSettings
    /// </summary>
    public partial class ChartAxisDefaultsLabelsRotationSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsLabelsRotationSettingsBuilder(ChartAxisDefaultsLabelsRotationSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsLabelsRotationSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
