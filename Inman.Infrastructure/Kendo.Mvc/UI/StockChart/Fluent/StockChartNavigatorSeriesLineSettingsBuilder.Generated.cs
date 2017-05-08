using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesLineSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The line color.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesLineSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The line opacity.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public StockChartNavigatorSeriesLineSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The line width.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSeriesLineSettingsBuilder<T> Width(string value)
        {
            Container.Width = value;
            return this;
        }

    }
}
