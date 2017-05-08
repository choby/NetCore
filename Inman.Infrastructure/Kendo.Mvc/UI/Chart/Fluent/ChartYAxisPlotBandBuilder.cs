using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisPlotBand
    /// </summary>
    public partial class ChartYAxisPlotBandBuilder<T>
        where T : class 
    {
        public ChartYAxisPlotBandBuilder(ChartYAxisPlotBand<T> container)
        {
            Container = container;
        }

        protected ChartYAxisPlotBand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
