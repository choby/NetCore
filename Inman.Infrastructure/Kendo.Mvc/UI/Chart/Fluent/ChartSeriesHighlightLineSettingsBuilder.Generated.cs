using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesHighlightLineSettings
    /// </summary>
    public partial class ChartSeriesHighlightLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The dash type of the highlight line.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartSeriesHighlightLineSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The line color. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesHighlightLineSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The opacity of the line. By default the border is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartSeriesHighlightLineSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The width of the line.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesHighlightLineSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
