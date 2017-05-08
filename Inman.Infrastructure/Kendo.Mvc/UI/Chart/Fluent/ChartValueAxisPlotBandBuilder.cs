using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisPlotBand
    /// </summary>
    public partial class ChartValueAxisPlotBandBuilder<T>
        where T : class 
    {
        public ChartValueAxisPlotBandBuilder(ChartValueAxisPlotBand<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisPlotBand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
