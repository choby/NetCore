using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesHighlightBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The border color.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The border opacity.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

    }
}
