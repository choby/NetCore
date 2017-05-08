using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartYAxis<T>>
    /// </summary>
    public partial class ChartYAxisFactory<T>
        where T : class 
    {
        public ChartYAxisFactory(List<ChartYAxis<T>> container)
        {
            Container = container;
        }

        protected List<ChartYAxis<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
