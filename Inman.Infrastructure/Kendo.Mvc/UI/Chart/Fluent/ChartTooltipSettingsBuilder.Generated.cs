using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTooltipSettings
    /// </summary>
    public partial class ChartTooltipSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the tooltip. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartTooltipSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartTooltipSettingsBuilder<T> Border(Action<ChartTooltipBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartTooltipBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the tooltip. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartTooltipSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The tooltip font.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartTooltipSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format of the labels. Uses kendo.format.Format placeholders:
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartTooltipSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The opacity of the tooltip.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartTooltipSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The padding of the tooltip. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartTooltipSettingsBuilder<T> Padding(Action<ChartTooltipPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartTooltipPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// If set to true the chart will display a single tooltip for every category.
        /// </summary>
        /// <param name="value">The value for Shared</param>
        public ChartTooltipSettingsBuilder<T> Shared(bool value)
        {
            Container.Shared = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display a single tooltip for every category.
        /// </summary>
        public ChartTooltipSettingsBuilder<T> Shared()
        {
            Container.Shared = true;
            return this;
        }

        /// <summary>
        /// The template which renders the shared tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for SharedTemplate</param>
        public ChartTooltipSettingsBuilder<T> SharedTemplate(string value)
        {
            Container.SharedTemplate = value;
            return this;
        }

        /// <summary>
        /// The template which renders the shared tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for SharedTemplate</param>
        public ChartTooltipSettingsBuilder<T> SharedTemplateId(string templateId)
        {
            Container.SharedTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartTooltipSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartTooltipSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series tooltip. By default the series tooltip is not displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartTooltipSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series tooltip. By default the series tooltip is not displayed.
        /// </summary>
        public ChartTooltipSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
