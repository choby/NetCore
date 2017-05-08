using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesOutliersBorderSettings
    /// </summary>
    public partial class ChartSeriesOutliersBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesOutliersBorderSettingsBuilder(ChartSeriesOutliersBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesOutliersBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
