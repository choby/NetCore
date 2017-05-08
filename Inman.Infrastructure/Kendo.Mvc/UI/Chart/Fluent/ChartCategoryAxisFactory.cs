using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartCategoryAxis<T>>
    /// </summary>
    public partial class ChartCategoryAxisFactory<T>
        where T : class 
    {
        public ChartCategoryAxisFactory(List<ChartCategoryAxis<T>> container)
        {
            Container = container;
        }

        protected List<ChartCategoryAxis<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
