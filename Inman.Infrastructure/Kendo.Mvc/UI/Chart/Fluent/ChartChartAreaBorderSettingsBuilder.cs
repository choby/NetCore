using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartChartAreaBorderSettings
    /// </summary>
    public partial class ChartChartAreaBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartChartAreaBorderSettingsBuilder(ChartChartAreaBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartChartAreaBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
