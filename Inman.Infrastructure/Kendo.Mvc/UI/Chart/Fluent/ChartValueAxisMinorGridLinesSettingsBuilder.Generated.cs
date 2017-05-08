using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartValueAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the minor grid lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the minor grid lines.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The type of grid lines to draw for radar charts:The default type is "line" except for "radarColumn" charts.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the minor grid lines. By default the minor grid lines are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the minor grid lines. By default the minor grid lines are visible.
        /// </summary>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the value axis minor grid lines in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the value axis minor grid lines.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the value axis minor grid lines.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartValueAxisMinorGridLinesSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
