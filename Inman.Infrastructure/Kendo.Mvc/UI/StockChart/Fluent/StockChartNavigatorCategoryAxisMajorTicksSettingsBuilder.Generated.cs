using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisMajorTicksSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the category axis major ticks lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the tick line in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis major ticks. By default the category axis major ticks are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the major ticks in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the category axis major ticks.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the category axis major ticks.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
