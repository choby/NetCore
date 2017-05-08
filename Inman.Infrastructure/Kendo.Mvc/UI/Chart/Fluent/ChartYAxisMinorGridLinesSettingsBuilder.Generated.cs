using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartYAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the minor grid lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the minor grid lines.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the minor grid lines. By default the minor grid lines are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the minor grid lines. By default the minor grid lines are visible.
        /// </summary>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the category axis minor grid lines in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the y axis minor grid lines.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the y axis minor grid lines.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartYAxisMinorGridLinesSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
