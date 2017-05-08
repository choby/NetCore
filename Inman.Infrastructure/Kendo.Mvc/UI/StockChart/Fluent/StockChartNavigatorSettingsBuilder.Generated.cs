using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSettings
    /// </summary>
    public partial class StockChartNavigatorSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The category axis configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the categoryaxis setting.</param>
        public StockChartNavigatorSettingsBuilder<T> CategoryAxis(Action<StockChartNavigatorCategoryAxisSettingsBuilder<T>> configurator)
        {

            Container.CategoryAxis.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisSettingsBuilder<T>(Container.CategoryAxis));

            return this;
        }

        /// <summary>
        /// Indicates whether the navigator will call read on the data source initially.
		/// Applicable only when using a dedicated navigator data source.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public StockChartNavigatorSettingsBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// The field containing the point date.
		/// It is used as a default field for the navigator axis.The data item field value must be either:
        /// </summary>
        /// <param name="value">The value for DateField</param>
        public StockChartNavigatorSettingsBuilder<T> DateField(string value)
        {
            Container.DateField = value;
            return this;
        }

        /// <summary>
        /// The navigator pane configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the pane setting.</param>
        public StockChartNavigatorSettingsBuilder<T> Pane(Action<StockChartNavigatorPaneSettingsBuilder<T>> configurator)
        {

            Container.Pane.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorPaneSettingsBuilder<T>(Container.Pane));

            return this;
        }

        /// <summary>
        /// The visibility of the navigator.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// Specifies the initially selected range.The full range of values is shown if no range is specified.
        /// </summary>
        /// <param name="configurator">The configurator for the select setting.</param>
        public StockChartNavigatorSettingsBuilder<T> Select(Action<StockChartNavigatorSelectSettingsBuilder<T>> configurator)
        {

            Container.Select.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSelectSettingsBuilder<T>(Container.Select));

            return this;
        }

        /// <summary>
        /// Default options for the navigator hint.
        /// </summary>
        /// <param name="configurator">The configurator for the hint setting.</param>
        public StockChartNavigatorSettingsBuilder<T> Hint(Action<StockChartNavigatorHintSettingsBuilder<T>> configurator)
        {

            Container.Hint.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorHintSettingsBuilder<T>(Container.Hint));

            return this;
        }

    }
}
