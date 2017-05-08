using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesHighlightSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The border of highlighted points. The color is computed automatically from the base point color.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Border(Action<StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The highlight color.** Available only for pie series **
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// Line options for highlighted points. The color is computed automatically from the base point color.** Available only for candlestick series **
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Line(Action<StockChartNavigatorSeriesHighlightLineSettingsBuilder<T>> configurator)
        {

            Container.Line.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesHighlightLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The opacity of the highlighted points.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// A value indicating if the series points should be highlighted.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
