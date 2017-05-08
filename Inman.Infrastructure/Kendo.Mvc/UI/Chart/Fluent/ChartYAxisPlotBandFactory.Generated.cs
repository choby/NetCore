using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI YAxisItem
    /// </summary>
    public partial class ChartYAxisPlotBandFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartYAxisPlotBandBuilder<T> Add()
        {
            var item = new ChartYAxisPlotBand<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartYAxisPlotBandBuilder<T>(item);
        }
    }
}
