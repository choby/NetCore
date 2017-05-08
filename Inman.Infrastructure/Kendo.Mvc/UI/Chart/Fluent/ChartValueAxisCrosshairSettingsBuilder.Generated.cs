using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisCrosshairSettings
    /// </summary>
    public partial class ChartValueAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the crosshair. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisCrosshairSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The opacity of the crosshair. By default the crosshair is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartValueAxisCrosshairSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The crosshair tooltip options.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public ChartValueAxisCrosshairSettingsBuilder<T> Tooltip(Action<ChartValueAxisCrosshairTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.Chart = Container.Chart;
            configurator(new ChartValueAxisCrosshairTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// If set to true the chart will display the value axis crosshair. By default the value axis crosshair is not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisCrosshairSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the value axis crosshair. By default the value axis crosshair is not visible.
        /// </summary>
        public ChartValueAxisCrosshairSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the crosshair in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartValueAxisCrosshairSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
