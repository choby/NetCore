using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Navigator
    /// </summary>
    public partial class StockChartNavigatorSettingsSeriesFactory<T>
        where T : class 
    {

        public StockChart<T> StockChart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual StockChartNavigatorSettingsSeriesBuilder<T> Add()
        {
            var item = new StockChartNavigatorSettingsSeries<T>();
            item.StockChart = StockChart;
            Container.Add(item);

            return new StockChartNavigatorSettingsSeriesBuilder<T>(item);
        }
    }
}
