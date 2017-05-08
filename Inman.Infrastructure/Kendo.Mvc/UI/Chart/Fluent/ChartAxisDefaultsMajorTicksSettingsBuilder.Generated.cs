using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsMajorTicksSettings
    /// </summary>
    public partial class ChartAxisDefaultsMajorTicksSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the axis major ticks lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartAxisDefaultsMajorTicksSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the tick line in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartAxisDefaultsMajorTicksSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the axis major ticks. By default the axis major ticks are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartAxisDefaultsMajorTicksSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the major ticks in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartAxisDefaultsMajorTicksSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the axis major ticks.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartAxisDefaultsMajorTicksSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the axis major ticks.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartAxisDefaultsMajorTicksSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
