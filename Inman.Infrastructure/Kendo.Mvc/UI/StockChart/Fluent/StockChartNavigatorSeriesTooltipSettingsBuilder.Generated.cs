using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesTooltipSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesTooltipSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the tooltip. The default is determined from the series color.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Border(Action<StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the tooltip. The default is the same as the series labels color.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The tooltip font.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The tooltip format. Format variables depend on the series type:
        /// </summary>
        /// <param name="value">The value for Format</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The padding of the tooltip.
        /// </summary>
        /// <param name="value">The value for Padding</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Padding(double value)
        {
            Container.Padding = value;
            return this;
        }

        /// <summary>
        /// The tooltip template.
		/// Template variables:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The tooltip template.
		/// Template variables:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// A value indicating if the tooltip should be displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A value indicating if the tooltip should be displayed.
        /// </summary>
        public StockChartNavigatorSeriesTooltipSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
