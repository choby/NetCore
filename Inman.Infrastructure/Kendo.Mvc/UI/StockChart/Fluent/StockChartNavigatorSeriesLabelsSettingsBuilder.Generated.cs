using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesLabelsSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Border(Action<StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format of the labels.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels.
        /// </summary>
        /// <param name="value">The value for Margin</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Margin(double value)
        {
            Container.Margin = value;
            return this;
        }

        /// <summary>
        /// The padding of the labels.
        /// </summary>
        /// <param name="value">The value for Padding</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Padding(double value)
        {
            Container.Padding = value;
            return this;
        }

        /// <summary>
        /// Defines the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Position(string value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The template which renders the chart series label.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the chart series label.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The visibility of the labels.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The visibility of the labels.
        /// </summary>
        public StockChartNavigatorSeriesLabelsSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
