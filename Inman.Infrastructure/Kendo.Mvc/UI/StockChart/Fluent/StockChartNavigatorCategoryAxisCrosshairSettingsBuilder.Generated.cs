using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisCrosshairSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the crosshair. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The opacity of the crosshair. By default the crosshair is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The crosshair tooltip options.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T> Tooltip(Action<StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis crosshair. By default the category axis crosshair is not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis crosshair. By default the category axis crosshair is not visible.
        /// </summary>
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the crosshair in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
