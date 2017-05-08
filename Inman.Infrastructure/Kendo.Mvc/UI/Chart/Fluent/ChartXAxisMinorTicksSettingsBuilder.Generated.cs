using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisMinorTicksSettings
    /// </summary>
    public partial class ChartXAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the x axis minor ticks lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartXAxisMinorTicksSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the tick line in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartXAxisMinorTicksSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the x axis minor ticks. By default the x axis minor ticks are not visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartXAxisMinorTicksSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the x axis minor ticks. By default the x axis minor ticks are not visible.
        /// </summary>
        public ChartXAxisMinorTicksSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the minor ticks in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartXAxisMinorTicksSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the x axis minor ticks.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartXAxisMinorTicksSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the x axis minor ticks.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartXAxisMinorTicksSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
