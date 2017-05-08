using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartValueAxis<T>>
    /// </summary>
    public partial class ChartValueAxisFactory<T>
        where T : class 
    {
        public ChartValueAxisFactory(List<ChartValueAxis<T>> container)
        {
            Container = container;
        }

        protected List<ChartValueAxis<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
