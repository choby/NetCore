using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxis
    /// </summary>
    public partial class ChartYAxisBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Value at which the Y axis crosses this axis. (Only for object)Value indices at which the Y axes cross the value axis. (Only for array)Date at which the Y axis crosses this axis. (Only for date)
        /// </summary>
        /// <param name="value">The value for AxisCrossingValue</param>
        public ChartYAxisBuilder<T> AxisCrossingValue(params object[] value)
        {
            Container.AxisCrossingValue = value;
            return this;
        }

        /// <summary>
        /// The background color of the axis.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartYAxisBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The base time interval for the axis labels. The default baseUnit is determined automatically from the value range. Available options:
        /// </summary>
        /// <param name="value">The value for BaseUnit</param>
        public ChartYAxisBuilder<T> BaseUnit(string value)
        {
            Container.BaseUnit = value;
            return this;
        }

        /// <summary>
        /// The color of the axis. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartYAxisBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The crosshair configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the crosshair setting.</param>
        public ChartYAxisBuilder<T> Crosshair(Action<ChartYAxisCrosshairSettingsBuilder<T>> configurator)
        {

            Container.Crosshair.Chart = Container.Chart;
            configurator(new ChartYAxisCrosshairSettingsBuilder<T>(Container.Crosshair));

            return this;
        }

        /// <summary>
        /// The axis labels configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public ChartYAxisBuilder<T> Labels(Action<ChartYAxisLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.Chart = Container.Chart;
            configurator(new ChartYAxisLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

        /// <summary>
        /// The configuration of the axis lines. Also affects the major and minor ticks, but not the grid lines.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartYAxisBuilder<T> Line(Action<ChartYAxisLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartYAxisLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The configuration of the major grid lines. These are the lines that are an extension of the major ticks through the
		/// body of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the majorgridlines setting.</param>
        public ChartYAxisBuilder<T> MajorGridLines(Action<ChartYAxisMajorGridLinesSettingsBuilder<T>> configurator)
        {

            Container.MajorGridLines.Chart = Container.Chart;
            configurator(new ChartYAxisMajorGridLinesSettingsBuilder<T>(Container.MajorGridLines));

            return this;
        }

        /// <summary>
        /// The configuration of the minor grid lines. These are the lines that are an extension of the minor ticks through the
		/// body of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the minorgridlines setting.</param>
        public ChartYAxisBuilder<T> MinorGridLines(Action<ChartYAxisMinorGridLinesSettingsBuilder<T>> configurator)
        {

            Container.MinorGridLines.Chart = Container.Chart;
            configurator(new ChartYAxisMinorGridLinesSettingsBuilder<T>(Container.MinorGridLines));

            return this;
        }

        /// <summary>
        /// The configuration of the y axis minor ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the minorticks setting.</param>
        public ChartYAxisBuilder<T> MinorTicks(Action<ChartYAxisMinorTicksSettingsBuilder<T>> configurator)
        {

            Container.MinorTicks.Chart = Container.Chart;
            configurator(new ChartYAxisMinorTicksSettingsBuilder<T>(Container.MinorTicks));

            return this;
        }

        /// <summary>
        /// The configuration of the scatter chart y axis major ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the majorticks setting.</param>
        public ChartYAxisBuilder<T> MajorTicks(Action<ChartYAxisMajorTicksSettingsBuilder<T>> configurator)
        {

            Container.MajorTicks.Chart = Container.Chart;
            configurator(new ChartYAxisMajorTicksSettingsBuilder<T>(Container.MajorTicks));

            return this;
        }

        /// <summary>
        /// The interval between major divisions.
		/// If this is a date axis the value represents the number of xAxis.baseUnits between major divisions.
		/// If the yAxis.type is set to "log", the majorUnit value will be used for the base of the logarithm.
        /// </summary>
        /// <param name="value">The value for MajorUnit</param>
        public ChartYAxisBuilder<T> MajorUnit(double value)
        {
            Container.MajorUnit = value;
            return this;
        }

        /// <summary>
        /// The maximum value of the axis.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public ChartYAxisBuilder<T> Max(object value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value of the axis.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public ChartYAxisBuilder<T> Min(object value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// The interval between minor divisions. It defaults to 1/5 of the yAxis.majorUnit.
		/// If the yAxis.type is set to "log", the minorUnit value represents the number of divisions between two major units and defaults to the major unit minus one.
        /// </summary>
        /// <param name="value">The value for MinorUnit</param>
        public ChartYAxisBuilder<T> MinorUnit(double value)
        {
            Container.MinorUnit = value;
            return this;
        }

        /// <summary>
        /// The unique axis name. Used to associate a series with a y axis using the series.yAxis option.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public ChartYAxisBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will prevent the automatic axis range from snapping to 0.
		/// Setting it to false will force the automatic axis range to snap to 0.
        /// </summary>
        /// <param name="value">The value for NarrowRange</param>
        public ChartYAxisBuilder<T> NarrowRange(bool value)
        {
            Container.NarrowRange = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will prevent the automatic axis range from snapping to 0.
		/// Setting it to false will force the automatic axis range to snap to 0.
        /// </summary>
        public ChartYAxisBuilder<T> NarrowRange()
        {
            Container.NarrowRange = true;
            return this;
        }

        /// <summary>
        /// The name of the pane that the axis should be rendered in.
		/// The axis will be rendered in the first (default) pane if not set.
        /// </summary>
        /// <param name="value">The value for Pane</param>
        public ChartYAxisBuilder<T> Pane(string value)
        {
            Container.Pane = value;
            return this;
        }

        /// <summary>
        /// The plot bands of the y axis.
        /// </summary>
        /// <param name="configurator">The configurator for the plotbands setting.</param>
        public ChartYAxisBuilder<T> PlotBands(Action<ChartYAxisPlotBandFactory<T>> configurator)
        {

            configurator(new ChartYAxisPlotBandFactory<T>(Container.PlotBands)
            {
                Chart = Container.Chart
            });

            return this;
        }

        /// <summary>
        /// If set to true the value axis direction will be reversed. By default values increase from left to right and from bottom to top.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public ChartYAxisBuilder<T> Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// If set to true the value axis direction will be reversed. By default values increase from left to right and from bottom to top.
        /// </summary>
        public ChartYAxisBuilder<T> Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// The title configuration of the scatter chart y axis.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public ChartYAxisBuilder<T> Title(Action<ChartYAxisTitleSettingsBuilder<T>> configurator)
        {

            Container.Title.Chart = Container.Chart;
            configurator(new ChartYAxisTitleSettingsBuilder<T>(Container.Title));

            return this;
        }

        /// <summary>
        /// The axis type.The supported values are:
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartYAxisBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the y axis. By default the y axis is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartYAxisBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The y axis notes configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the notes setting.</param>
        public ChartYAxisBuilder<T> Notes(Action<ChartYAxisNotesSettingsBuilder<T>> configurator)
        {

            Container.Notes.Chart = Container.Chart;
            configurator(new ChartYAxisNotesSettingsBuilder<T>(Container.Notes));

            return this;
        }

    }
}
