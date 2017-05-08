using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSettingsSeries
    /// </summary>
    public partial class StockChartNavigatorSettingsSeriesBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The type of the series. Available types:
        /// </summary>
        /// <param name="value">The value for Type</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// The dash type of line chart.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The data field containing the high value.** Available for candlestick and ohlc series only **
        /// </summary>
        /// <param name="value">The value for HighField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> HighField(string value)
        {
            Container.HighField = value;
            return this;
        }

        /// <summary>
        /// The data field containing the series value.
        /// </summary>
        /// <param name="value">The value for Field</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Field(string value)
        {
            Container.Field = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the category name or date.
        /// </summary>
        /// <param name="value">The value for CategoryField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> CategoryField(string value)
        {
            Container.CategoryField = value;
            return this;
        }

        /// <summary>
        /// The navigator series name.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// Configures the appearance of highlighted points.** Applicable to candlestick and ohlc series. **
        /// </summary>
        /// <param name="configurator">The configurator for the highlight setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Highlight(Action<StockChartNavigatorSeriesHighlightSettingsBuilder<T>> configurator)
        {

            Container.Highlight.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesHighlightSettingsBuilder<T>(Container.Highlight));

            return this;
        }

        /// <summary>
        /// The aggregate function to apply for date series.This function is used when a category (an year, month, etc.) contains two or more points.
		/// The function return value is displayed instead of the individual points.The supported values are:
        /// </summary>
        /// <param name="value">The value for Aggregate</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Aggregate(string value)
        {
            Container.AggregateHandler = null;
            Container.Aggregate = value;
            return this;
        }
        /// <summary>
        /// The aggregate function to apply for date series.This function is used when a category (an year, month, etc.) contains two or more points.
		/// The function return value is displayed instead of the individual points.The supported values are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> AggregateHandler(string handler)
        {
            Container.Aggregate = null;
            Container.AggregateHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The aggregate function to apply for date series.This function is used when a category (an year, month, etc.) contains two or more points.
		/// The function return value is displayed instead of the individual points.The supported values are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> AggregateHandler(Func<object, object> handler)
        {
            Container.Aggregate = null;
            Container.AggregateHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The name of the value axis to use.** Applicable to area, column, line, ohlc and candlestick series **
        /// </summary>
        /// <param name="value">The value for Axis</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Axis(string value)
        {
            Container.Axis = value;
            return this;
        }

        /// <summary>
        /// The border of the points.** Applicable to column, ohlc and candlestick series **
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Border(Action<StockChartNavigatorSeriesBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The data field containing the close value.** Available for candlestick and ohlc series only **
        /// </summary>
        /// <param name="value">The value for CloseField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> CloseField(string value)
        {
            Container.CloseField = value;
            return this;
        }

        /// <summary>
        /// The series base color. The supported values are:
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The data field containing the point color.** Applicable for column, candlestick and ohlc series. **
        /// </summary>
        /// <param name="value">The value for ColorField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> ColorField(string value)
        {
            Container.ColorField = value;
            return this;
        }

        /// <summary>
        /// The series color when the open value is greater than the close value.** Available for candlestick series only **
        /// </summary>
        /// <param name="value">The value for DownColor</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> DownColor(string value)
        {
            Container.DownColor = value;
            return this;
        }

        /// <summary>
        /// The data field containing the color applied when the open value is greater than the close value.** Available for candlestick series only **
        /// </summary>
        /// <param name="value">The value for DownColorField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> DownColorField(string value)
        {
            Container.DownColorField = value;
            return this;
        }

        /// <summary>
        /// The distance between category clusters.** Applicable for column, candlestick and ohlc series. **
        /// </summary>
        /// <param name="value">The value for Gap</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Gap(double value)
        {
            Container.Gap = value;
            return this;
        }

        /// <summary>
        /// Configures the series data labels.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Labels(Action<StockChartNavigatorSeriesLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

        /// <summary>
        /// Line options.** Applicable to area, candlestick and ohlc series. **
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Line(Action<StockChartNavigatorSeriesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The data field containing the low value.** Available for candlestick and ohlc series **
        /// </summary>
        /// <param name="value">The value for LowField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> LowField(string value)
        {
            Container.LowField = value;
            return this;
        }

        /// <summary>
        /// Marker options.** Applicable for area and line series. **
        /// </summary>
        /// <param name="configurator">The configurator for the markers setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Markers(Action<StockChartNavigatorSeriesMarkersSettingsBuilder<T>> configurator)
        {

            Container.Markers.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesMarkersSettingsBuilder<T>(Container.Markers));

            return this;
        }

        /// <summary>
        /// The behavior for handling missing values. The supported values are:
        /// </summary>
        /// <param name="value">The value for MissingValues</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> MissingValues(string value)
        {
            Container.MissingValues = value;
            return this;
        }

        /// <summary>
        /// The supported values are:
        /// </summary>
        /// <param name="value">The value for Style</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Style(string value)
        {
            Container.Style = value;
            return this;
        }

        /// <summary>
        /// The series opacity.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The data field containing the open value.** Available for candlestick and ohlc series **
        /// </summary>
        /// <param name="value">The value for OpenField</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> OpenField(string value)
        {
            Container.OpenField = value;
            return this;
        }

        /// <summary>
        /// The effects overlay.
        /// </summary>
        /// <param name="configurator">The configurator for the overlay setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Overlay(Action<StockChartNavigatorSeriesOverlaySettingsBuilder<T>> configurator)
        {

            Container.Overlay.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesOverlaySettingsBuilder<T>(Container.Overlay));

            return this;
        }

        /// <summary>
        /// Space between points as proportion of the point width.Available for column, candlestick and ohlc series.
        /// </summary>
        /// <param name="value">The value for Spacing</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Spacing(double value)
        {
            Container.Spacing = value;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if the series should be stacked.
		/// A string value is interpreted as navigator.series.stack.group.
        /// </summary>
        /// <param name="configurator">The configurator for the stack setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Stack(Action<StockChartNavigatorSeriesStackSettingsBuilder<T>> configurator)
        {
            Container.Stack.Enabled = true;

            Container.Stack.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesStackSettingsBuilder<T>(Container.Stack));

            return this;
        }

        /// <summary>
        /// A boolean value indicating if the series should be stacked.
		/// A string value is interpreted as navigator.series.stack.group.
        /// </summary>
        public StockChartNavigatorSettingsSeriesBuilder<T> Stack()
        {
            Container.Stack.Enabled = true;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if the series should be stacked.
		/// A string value is interpreted as navigator.series.stack.group.
        /// </summary>
        /// <param name="enabled">Enables or disables the stack option.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Stack(bool enabled)
        {
            Container.Stack.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The data point tooltip configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Tooltip(Action<StockChartNavigatorSeriesTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSeriesTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// The line width.** Applicable for line series. **
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSettingsSeriesBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
