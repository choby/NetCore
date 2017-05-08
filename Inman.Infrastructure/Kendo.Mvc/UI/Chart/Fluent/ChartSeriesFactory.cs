using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartSeries<T>>
    /// </summary>
    public partial class ChartSeriesFactory<T>
        where T : class 
    {
        public ChartSeriesFactory(List<ChartSeries<T>> container)
        {
            Container = container;
        }

        public Chart<T> Chart { get; set; }

        protected List<ChartSeries<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
