using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitleSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitleSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the title.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Border(Action<StockChartNavigatorCategoryAxisTitleBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisTitleBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the title.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The margin of the title. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Margin(Action<StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the title. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Padding(Action<StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The position of the title.The supported values are:
        /// </summary>
        /// <param name="value">The value for Position</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Position(string value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The rotation angle of the title. By default the title is not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The text of the title.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis title. By default the category axis title is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
