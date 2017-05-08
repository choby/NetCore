using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartCategoryAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the minor grid lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the minor grid lines.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the minor grid lines. By default the minor grid lines are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the minor grid lines. By default the minor grid lines are visible.
        /// </summary>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the category axis minor grid lines in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the category axis minor grid lines.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the category axis minor grid lines.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartCategoryAxisMinorGridLinesSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
