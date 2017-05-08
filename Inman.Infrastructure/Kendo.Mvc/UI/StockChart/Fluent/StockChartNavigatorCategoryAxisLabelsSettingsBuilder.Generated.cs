using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Border(Action<StockChartNavigatorCategoryAxisLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The culture to use when formatting date values. See the globalization overview for more information.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels when the categories are dates. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="configurator">The configurator for the dateformats setting.</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> DateFormats(Action<StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T>> configurator)
        {

            Container.DateFormats.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisLabelsDateFormatsSettingsBuilder<T>(Container.DateFormats));

            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Margin(Action<StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Mirror()
        {
            Container.Mirror = true;
            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Padding(Action<StockChartNavigatorCategoryAxisLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The number of labels to skip. By default no labels are skipped.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

        /// <summary>
        /// The label rendering step - render every n-th label. By default every label is rendered.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis labels. By default the category axis labels are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
