using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI CategoryAxisItem
    /// </summary>
    public partial class ChartCategoryAxisPlotBandFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartCategoryAxisPlotBandBuilder<T> Add()
        {
            var item = new ChartCategoryAxisPlotBand<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartCategoryAxisPlotBandBuilder<T>(item);
        }
    }
}
