using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI ValueAxisItem
    /// </summary>
    public partial class ChartValueAxisPlotBandFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartValueAxisPlotBandBuilder<T> Add()
        {
            var item = new ChartValueAxisPlotBand<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartValueAxisPlotBandBuilder<T>(item);
        }
    }
}
