using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Chart
    /// </summary>
    public partial class ChartYAxisFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartYAxisBuilder<T> Add()
        {
            var item = new ChartYAxis<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartYAxisBuilder<T>(item);
        }
    }
}
