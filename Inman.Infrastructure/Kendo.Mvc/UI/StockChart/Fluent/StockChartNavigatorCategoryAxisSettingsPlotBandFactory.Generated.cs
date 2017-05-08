using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI CategoryAxis
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T>
        where T : class 
    {

        public StockChart<T> StockChart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual StockChartNavigatorCategoryAxisSettingsPlotBandBuilder<T> Add()
        {
            var item = new StockChartNavigatorCategoryAxisSettingsPlotBand<T>();
            item.StockChart = StockChart;
            Container.Add(item);

            return new StockChartNavigatorCategoryAxisSettingsPlotBandBuilder<T>(item);
        }
    }
}
