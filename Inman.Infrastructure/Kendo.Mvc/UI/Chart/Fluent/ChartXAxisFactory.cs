using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartXAxis<T>>
    /// </summary>
    public partial class ChartXAxisFactory<T>
        where T : class 
    {
        public ChartXAxisFactory(List<ChartXAxis<T>> container)
        {
            Container = container;
        }

        protected List<ChartXAxis<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
