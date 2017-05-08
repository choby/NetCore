using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisCrosshairTooltipSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the tooltip. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border options.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Border(Action<StockChartNavigatorCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the tooltip. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The tooltip font.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the tooltip. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The padding of the crosshair tooltip. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Padding(Action<StockChartNavigatorCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis crosshair tooltip. By default the category axis crosshair tooltip is not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis crosshair tooltip. By default the category axis crosshair tooltip is not visible.
        /// </summary>
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
