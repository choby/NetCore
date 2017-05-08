using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMinorTicksSettings
    /// </summary>
    public partial class ChartValueAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the value axis minor ticks lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the tick line in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the value axis minor ticks. By default the value axis minor ticks are not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the value axis minor ticks. By default the value axis minor ticks are not visible.
        /// </summary>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the minor ticks in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the value axis minor ticks.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the value axis minor ticks.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartValueAxisMinorTicksSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
