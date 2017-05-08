using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSettings
    /// </summary>
    public partial class StockChartNavigatorSettingsBuilder<T>
        where T : class
    {
        public StockChartNavigatorSettingsBuilder(StockChartNavigatorSettings<T> container)
        {
            Container = container;
        }
        
        protected StockChartNavigatorSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
        
        /// <summary>
        /// Data Source configuration for the Navigator.
        /// When configured, the Navigator will filter the main StockChart data source to the selected range.
        /// </summary>
        /// <param name="configurator">Use the configurator to set different data binding options.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().StockChart()
        ///             .Name("Chart")
        ///             .Navigator(navi => navi
        ///             .DataSource(ds =>
        ///                 {
        ///                     ds.Ajax().Read(r => r.Action("SalesData", "Chart"));
        ///                 })
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public StockChartNavigatorSettingsBuilder<T> DataSource(Action<ReadOnlyAjaxDataSourceBuilder<T>> configurator)
        {
            configurator(new ReadOnlyAjaxDataSourceBuilder<T>(Container.DataSource, Container.ViewContext, Container.UrlGenerator));

            return this;
        }

        /// <summary>
        /// Sets the selection range
        /// </summary>
        /// <param name="from">The selection range start.</param>
        /// <param name="to">The selection range end.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().StockChart(Model)
        ///           .Name("StockChart")
        ///           .Navigator(nav => nav.Select(DateTime.Today.AddMonths(-1), DateTime.Today))
        /// %&gt;
        /// </code>
        /// </example>        
        public StockChartNavigatorSettingsBuilder<T> Select(DateTime? from, DateTime? to)
        {
            Container.Select.From = from;
            Container.Select.To = to;

            return this;
        }

        /// <summary>
        /// The configuration of the chart series.The series type is determined by the value of the type field.
        /// If a type value is missing, the type is assumed to be the one specified in seriesDefaults.
        /// </summary>
        /// <param name="configurator">The configurator for the series setting.</param>
        public StockChartNavigatorSettingsBuilder<T> Series(Action<ChartSeriesFactory<T>> configurator)
        {
            configurator(new ChartSeriesFactory<T>(Container.Series)
            {
                Chart = Container.StockChart
            });

            return this;
        }
    }
}
