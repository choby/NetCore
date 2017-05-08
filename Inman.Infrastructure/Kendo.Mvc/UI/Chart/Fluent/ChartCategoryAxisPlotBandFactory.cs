using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartCategoryAxisPlotBand<T>>
    /// </summary>
    public partial class ChartCategoryAxisPlotBandFactory<T>
        where T : class 
    {
        public ChartCategoryAxisPlotBandFactory(List<ChartCategoryAxisPlotBand<T>> container)
        {
            Container = container;
        }

        protected List<ChartCategoryAxisPlotBand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
