using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesErrorBarsLineSettings
    /// </summary>
    public partial class ChartSeriesErrorBarsLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The width of the line.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesErrorBarsLineSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The dash type of the error bars line.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartSeriesErrorBarsLineSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

    }
}
