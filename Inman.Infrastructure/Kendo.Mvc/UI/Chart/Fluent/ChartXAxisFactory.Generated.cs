using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Chart
    /// </summary>
    public partial class ChartXAxisFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartXAxisBuilder<T> Add()
        {
            var item = new ChartXAxis<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartXAxisBuilder<T>(item);
        }
    }
}
