using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMajorTicksSettings
    /// </summary>
    public partial class ChartValueAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the value axis major ticks lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisMajorTicksSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the tick line in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartValueAxisMajorTicksSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the value axis major ticks. By default the value axis major ticks are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisMajorTicksSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The step of the value axis major ticks.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartValueAxisMajorTicksSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the value axis major ticks.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartValueAxisMajorTicksSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
