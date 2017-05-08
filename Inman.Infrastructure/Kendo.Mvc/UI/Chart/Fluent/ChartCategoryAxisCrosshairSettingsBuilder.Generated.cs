using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisCrosshairSettings
    /// </summary>
    public partial class ChartCategoryAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the crosshair. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the crosshair.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The opacity of the crosshair. By default the crosshair is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The crosshair tooltip options.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> Tooltip(Action<ChartCategoryAxisCrosshairTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.Chart = Container.Chart;
            configurator(new ChartCategoryAxisCrosshairTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis crosshair. By default the category axis crosshair is not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis crosshair. By default the category axis crosshair is not visible.
        /// </summary>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the crosshair in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartCategoryAxisCrosshairSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
