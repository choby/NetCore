using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLineSettings
    /// </summary>
    public partial class ChartSeriesLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The line color. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesLineSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The line opacity. By default the line is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartSeriesLineSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The line width in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesLineSettingsBuilder<T> Width(string value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// Specifies the preferred line rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        public ChartSeriesLineSettingsBuilder<T> Style(ChartSeriesLineStyle value)
        {
            Container.Style = value;
            return this;
        }

    }
}
