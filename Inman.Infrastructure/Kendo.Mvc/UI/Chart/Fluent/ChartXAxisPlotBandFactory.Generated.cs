using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI XAxisItem
    /// </summary>
    public partial class ChartXAxisPlotBandFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartXAxisPlotBandBuilder<T> Add()
        {
            var item = new ChartXAxisPlotBand<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartXAxisPlotBandBuilder<T>(item);
        }
    }
}
