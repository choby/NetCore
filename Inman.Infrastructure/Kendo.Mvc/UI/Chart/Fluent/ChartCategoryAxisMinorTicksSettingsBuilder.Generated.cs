using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisMinorTicksSettings
    /// </summary>
    public partial class ChartCategoryAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the category axis minor ticks lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartCategoryAxisMinorTicksSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the tick line in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartCategoryAxisMinorTicksSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis minor ticks. By default the category axis minor ticks are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartCategoryAxisMinorTicksSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the minor ticks in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartCategoryAxisMinorTicksSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the category axis minor ticks.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartCategoryAxisMinorTicksSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the category axis minor ticks.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartCategoryAxisMinorTicksSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
