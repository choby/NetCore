using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The discrete navigator.categoryAxis.baseUnitStep values when
		/// either navigator.categoryAxis.baseUnit is set to "fit" or
		/// navigator.categoryAxis.baseUnitStep is set to "auto".
        /// </summary>
        /// <param name="configurator">The configurator for the autobaseunitsteps setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> AutoBaseUnitSteps(Action<StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>> configurator)
        {

            Container.AutoBaseUnitSteps.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>(Container.AutoBaseUnitSteps));

            return this;
        }

        /// <summary>
        /// Category index at which the first value axis crosses this axis (when set as an object).Category indices at which the value axes cross the category axis (when set as an array).
        /// </summary>
        /// <param name="value">The value for AxisCrossingValue</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> AxisCrossingValue(params object[] value)
        {
            Container.AxisCrossingValue = value;
            return this;
        }

        /// <summary>
        /// The background color of the axis.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The step (interval) between categories in base units. Setting it to "auto" will set the step to such value
		/// that the total number of categories does not exceed categoryAxis.maxDateGroups.This option is ignored if categoryAxis.baseUnit is set to "fit".
        /// </summary>
        /// <param name="value">The value for BaseUnitStep</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> BaseUnitStep(int value)
        {
            Container.BaseUnitStep = value;
            return this;
        }

        /// <summary>
        /// The category names. The chart will create a category for every item of the array.
        /// </summary>
        /// <param name="value">The value for Categories</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Categories(params object[] value)
        {
            Container.Categories = value;
            return this;
        }

        /// <summary>
        /// The color to apply to all axis elements. Accepts a valid CSS color string, including hex and rgb. Can be overridden by categoryAxis.labels.color and
		/// categoryAxis.line.color.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The crosshair configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the crosshair setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Crosshair(Action<StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T>> configurator)
        {

            Container.Crosshair.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T>(Container.Crosshair));

            return this;
        }

        /// <summary>
        /// The data item field which contains the category name. Requires the dataSource option to be set.
        /// </summary>
        /// <param name="value">The value for Field</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Field(string value)
        {
            Container.Field = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will position categories and series points on major ticks. This removes the empty space before and after the series.The default value is false except for "area" and "verticalArea".
        /// </summary>
        /// <param name="value">The value for Justified</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Justified(bool value)
        {
            Container.Justified = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will position categories and series points on major ticks. This removes the empty space before and after the series.The default value is false except for "area" and "verticalArea".
        /// </summary>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Justified()
        {
            Container.Justified = true;
            return this;
        }

        /// <summary>
        /// The axis labels configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Labels(Action<StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

        /// <summary>
        /// The configuration of the axis lines. Also affects the major and minor ticks, but not the grid lines.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Line(Action<StockChartNavigatorCategoryAxisLineSettingsBuilder<T>> configurator)
        {

            Container.Line.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The configuration of the major grid lines. These are the lines that are an extension of the major ticks through the
		/// body of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the majorgridlines setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> MajorGridLines(Action<StockChartNavigatorCategoryAxisMajorGridLinesSettingsBuilder<T>> configurator)
        {

            Container.MajorGridLines.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisMajorGridLinesSettingsBuilder<T>(Container.MajorGridLines));

            return this;
        }

        /// <summary>
        /// The configuration of the category axis major ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the majorticks setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> MajorTicks(Action<StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T>> configurator)
        {

            Container.MajorTicks.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T>(Container.MajorTicks));

            return this;
        }

        /// <summary>
        /// The last date displayed on the category date axis. By default, the minimum date is the same as the last category.
		/// This is often used in combination with the categoryAxis.min and categoryAxis.roundToBaseUnit options to
		/// set up a fixed date range.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Max(object value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The maximum number of groups (categories) to display when
		/// categoryAxis.baseUnit is set to "fit" or
		/// categoryAxis.baseUnitStep is set to "auto".
        /// </summary>
        /// <param name="value">The value for MaxDateGroups</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> MaxDateGroups(double value)
        {
            Container.MaxDateGroups = value;
            return this;
        }

        /// <summary>
        /// The first date displayed on the category date axis. By default, the minimum date is the same as the first category.
		/// This is often used in combination with the categoryAxis.min and categoryAxis.roundToBaseUnit options to
		/// set up a fixed date range.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Min(object value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// The configuration of the minor grid lines. These are the lines that are an extension of the minor ticks through the
		/// body of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the minorgridlines setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> MinorGridLines(Action<StockChartNavigatorCategoryAxisMinorGridLinesSettingsBuilder<T>> configurator)
        {

            Container.MinorGridLines.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisMinorGridLinesSettingsBuilder<T>(Container.MinorGridLines));

            return this;
        }

        /// <summary>
        /// The configuration of the category axis minor ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the minorticks setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> MinorTicks(Action<StockChartNavigatorCategoryAxisMinorTicksSettingsBuilder<T>> configurator)
        {

            Container.MinorTicks.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisMinorTicksSettingsBuilder<T>(Container.MinorTicks));

            return this;
        }

        /// <summary>
        /// The plot bands of the category axis.
        /// </summary>
        /// <param name="configurator">The configurator for the plotbands setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> PlotBands(Action<StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T>> configurator)
        {

            configurator(new StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T>(Container.PlotBands)
            {
                StockChart = Container.StockChart
            });

            return this;
        }

        /// <summary>
        /// If set to true the category axis direction will be reversed. By default categories are listed from left to right and from bottom to top.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// If set to true the category axis direction will be reversed. By default categories are listed from left to right and from bottom to top.
        /// </summary>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// If set to true the chart will round the first and last date to the nearest base unit.The roundToBaseUnit option will be ignored if series.type is set to "bar", "column", "ohlc" or "candlestick".
        /// </summary>
        /// <param name="value">The value for RoundToBaseUnit</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> RoundToBaseUnit(bool value)
        {
            Container.RoundToBaseUnit = value;
            return this;
        }

        /// <summary>
        /// The title configuration of the category axis.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Title(Action<StockChartNavigatorCategoryAxisTitleSettingsBuilder<T>> configurator)
        {

            Container.Title.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisTitleSettingsBuilder<T>(Container.Title));

            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis. By default the category axis is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The week start day when categoryAxis.baseUnit is set to "weeks".The supported values are:
        /// </summary>
        /// <param name="value">The value for WeekStartDay</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> WeekStartDay(double value)
        {
            Container.WeekStartDay = value;
            return this;
        }

        /// <summary>
        /// The category axis notes configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the notes setting.</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Notes(Action<StockChartNavigatorCategoryAxisNotesSettingsBuilder<T>> configurator)
        {

            Container.Notes.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisNotesSettingsBuilder<T>(Container.Notes));

            return this;
        }

        /// <summary>
        /// Specifies the base time interval for the axis.
        /// </summary>
        /// <param name="value">The value for BaseUnit</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> BaseUnit(ChartAxisBaseUnit value)
        {
            Container.BaseUnit = value;
            return this;
        }

        /// <summary>
        /// Specifies the category axis type.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public StockChartNavigatorCategoryAxisSettingsBuilder<T> Type(ChartCategoryAxisType value)
        {
            Container.Type = value;
            return this;
        }

    }
}
