using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisPlotBand
    /// </summary>
    public partial class ChartCategoryAxisPlotBandBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisPlotBandBuilder(ChartCategoryAxisPlotBand<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisPlotBand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
