using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisMajorGridLinesSettings
    /// </summary>
    public partial class ChartXAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartXAxisMajorGridLinesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the line.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartXAxisMajorGridLinesSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the x major grid lines. By default the x major grid lines are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartXAxisMajorGridLinesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the line in pixels. Also affects the major and minor ticks, but not the grid lines.
		/// #### Example - set the scatter chart x major grid lines width
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartXAxisMajorGridLinesSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the x axis major grid lines.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartXAxisMajorGridLinesSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the x axis major grid lines.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartXAxisMajorGridLinesSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
