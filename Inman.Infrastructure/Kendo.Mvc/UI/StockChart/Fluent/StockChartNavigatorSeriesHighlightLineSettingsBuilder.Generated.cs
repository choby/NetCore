using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesHighlightLineSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The width of the line.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSeriesHighlightLineSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The line color.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesHighlightLineSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The opacity of the line.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public StockChartNavigatorSeriesHighlightLineSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

    }
}
