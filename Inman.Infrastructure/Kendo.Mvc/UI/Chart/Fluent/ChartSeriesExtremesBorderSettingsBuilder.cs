using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesExtremesBorderSettings
    /// </summary>
    public partial class ChartSeriesExtremesBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesExtremesBorderSettingsBuilder(ChartSeriesExtremesBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesExtremesBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
