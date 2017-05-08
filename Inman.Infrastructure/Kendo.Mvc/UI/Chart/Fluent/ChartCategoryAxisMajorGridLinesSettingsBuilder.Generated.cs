using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisMajorGridLinesSettings
    /// </summary>
    public partial class ChartCategoryAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the major grid lines. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the major grid lines.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the major grid lines. By default the major grid lines are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the major grid lines. By default the major grid lines are visible.
        /// </summary>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// The width of the category axis major grid lines in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The step of the category axis major grid lines.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The skip of the category axis major grid lines.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartCategoryAxisMajorGridLinesSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

    }
}
