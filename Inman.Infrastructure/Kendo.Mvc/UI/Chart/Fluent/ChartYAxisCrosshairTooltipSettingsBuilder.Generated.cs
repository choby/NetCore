using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisCrosshairTooltipSettings
    /// </summary>
    public partial class ChartYAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the tooltip. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border options.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Border(Action<ChartYAxisCrosshairTooltipBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartYAxisCrosshairTooltipBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the tooltip. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The tooltip font.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the tooltip. Uses kendo.format. Contains one placeholder ("{0}") which represents the value value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The padding of the crosshair tooltip. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Padding(Action<ChartYAxisCrosshairTooltipPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartYAxisCrosshairTooltipPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the tooltip.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the scatter chart y axis crosshair tooltip. By default the scatter chart y axis crosshair tooltip is not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the scatter chart y axis crosshair tooltip. By default the scatter chart y axis crosshair tooltip is not visible.
        /// </summary>
        public ChartYAxisCrosshairTooltipSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
