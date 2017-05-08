using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartYAxisPlotBand<T>>
    /// </summary>
    public partial class ChartYAxisPlotBandFactory<T>
        where T : class 
    {
        public ChartYAxisPlotBandFactory(List<ChartYAxisPlotBand<T>> container)
        {
            Container = container;
        }

        protected List<ChartYAxisPlotBand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
