using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMajorGridLinesSettings
    /// </summary>
    public partial class ChartValueAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the major grid lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the major grid lines.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The type of grid lines to draw for radar charts:The default type is "line" except for "radarColumn" charts.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the major grid lines. By default the major grid lines are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the major grid lines. By default the major grid lines are visible.
        /// </summary>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the value axis major grid lines in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the value axis major grid lines.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the value axis major grid lines.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartValueAxisMajorGridLinesSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
