using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneSettings
    /// </summary>
    public partial class StockChartNavigatorPaneSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the pane. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the navigator pane.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Border(Action<StockChartNavigatorPaneBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorPaneBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The navigator pane height in pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The margin of the pane. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Margin(Action<StockChartNavigatorPaneMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorPaneMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The unique name of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The padding of the pane. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Padding(Action<StockChartNavigatorPanePaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorPanePaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The title configuration of the navigator pane.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public StockChartNavigatorPaneSettingsBuilder<T> Title(Action<StockChartNavigatorPaneTitleSettingsBuilder<T>> configurator)
        {

            Container.Title.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorPaneTitleSettingsBuilder<T>(Container.Title));

            return this;
        }

    }
}
