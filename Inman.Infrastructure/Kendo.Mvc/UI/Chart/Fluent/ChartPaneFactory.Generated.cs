using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Chart
    /// </summary>
    public partial class ChartPaneFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartPaneBuilder<T> Add()
        {
            var item = new ChartPane<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartPaneBuilder<T>(item);
        }
    }
}
