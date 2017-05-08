using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisPlotBand
    /// </summary>
    public partial class ChartXAxisPlotBandBuilder<T>
        where T : class 
    {
        public ChartXAxisPlotBandBuilder(ChartXAxisPlotBand<T> container)
        {
            Container = container;
        }

        protected ChartXAxisPlotBand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
