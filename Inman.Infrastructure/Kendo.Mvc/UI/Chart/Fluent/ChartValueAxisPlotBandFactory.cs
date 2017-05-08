using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartValueAxisPlotBand<T>>
    /// </summary>
    public partial class ChartValueAxisPlotBandFactory<T>
        where T : class 
    {
        public ChartValueAxisPlotBandFactory(List<ChartValueAxisPlotBand<T>> container)
        {
            Container = container;
        }

        protected List<ChartValueAxisPlotBand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
