using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsSettings
    /// </summary>
    public partial class ChartAxisDefaultsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the axis.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartAxisDefaultsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The color to apply to all axis elements. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartAxisDefaultsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The crosshair configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the crosshair setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> Crosshair(Action<ChartAxisDefaultsCrosshairSettingsBuilder<T>> configurator)
        {

            Container.Crosshair.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsCrosshairSettingsBuilder<T>(Container.Crosshair));

            return this;
        }

        /// <summary>
        /// The axis labels configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> Labels(Action<ChartAxisDefaultsLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

        /// <summary>
        /// The configuration of the axis lines. Also affects the major and minor ticks, but not the grid lines.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> Line(Action<ChartAxisDefaultsLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The configuration of the major grid lines. These are the lines that are an extension of the major ticks through the
		/// body of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the majorgridlines setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> MajorGridLines(Action<ChartAxisDefaultsMajorGridLinesSettingsBuilder<T>> configurator)
        {

            Container.MajorGridLines.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsMajorGridLinesSettingsBuilder<T>(Container.MajorGridLines));

            return this;
        }

        /// <summary>
        /// The configuration of the axis major ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the majorticks setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> MajorTicks(Action<ChartAxisDefaultsMajorTicksSettingsBuilder<T>> configurator)
        {

            Container.MajorTicks.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsMajorTicksSettingsBuilder<T>(Container.MajorTicks));

            return this;
        }

        /// <summary>
        /// The configuration of the minor grid lines. These are the lines that are an extension of the minor ticks through the
		/// body of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the minorgridlines setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> MinorGridLines(Action<ChartAxisDefaultsMinorGridLinesSettingsBuilder<T>> configurator)
        {

            Container.MinorGridLines.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsMinorGridLinesSettingsBuilder<T>(Container.MinorGridLines));

            return this;
        }

        /// <summary>
        /// The configuration of the axis minor ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the minorticks setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> MinorTicks(Action<ChartAxisDefaultsMinorTicksSettingsBuilder<T>> configurator)
        {

            Container.MinorTicks.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsMinorTicksSettingsBuilder<T>(Container.MinorTicks));

            return this;
        }

        /// <summary>
        /// If set to true the chart will prevent the axis range from snapping to 0.
		/// Setting it to false will force the axis range to snap to 0.
        /// </summary>
        /// <param name="value">The value for NarrowRange</param>
        public ChartAxisDefaultsSettingsBuilder<T> NarrowRange(bool value)
        {
            Container.NarrowRange = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will prevent the axis range from snapping to 0.
		/// Setting it to false will force the axis range to snap to 0.
        /// </summary>
        public ChartAxisDefaultsSettingsBuilder<T> NarrowRange()
        {
            Container.NarrowRange = true;
            return this;
        }

        /// <summary>
        /// The name of the pane that the axis should be rendered in.
		/// The axis will be rendered in the first (default) pane if not set.
        /// </summary>
        /// <param name="value">The value for Pane</param>
        public ChartAxisDefaultsSettingsBuilder<T> Pane(string value)
        {
            Container.Pane = value;
            return this;
        }

        /// <summary>
        /// The plot bands of the axis.
        /// </summary>
        /// <param name="configurator">The configurator for the plotbands setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> PlotBands(Action<ChartAxisDefaultsSettingsPlotBandFactory<T>> configurator)
        {

            configurator(new ChartAxisDefaultsSettingsPlotBandFactory<T>(Container.PlotBands)
            {
                Chart = Container.Chart
            });

            return this;
        }

        /// <summary>
        /// If set to true the axis direction will be reversed. By default categories are listed from left to right and from bottom to top.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public ChartAxisDefaultsSettingsBuilder<T> Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// If set to true the axis direction will be reversed. By default categories are listed from left to right and from bottom to top.
        /// </summary>
        public ChartAxisDefaultsSettingsBuilder<T> Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// The angle (degrees) of the first category on the axis.Angles increase clockwise and zero is to the left. Negative values are acceptable.
        /// </summary>
        /// <param name="value">The value for StartAngle</param>
        public ChartAxisDefaultsSettingsBuilder<T> StartAngle(double value)
        {
            Container.StartAngle = value;
            return this;
        }

        /// <summary>
        /// The title configuration of the axis.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public ChartAxisDefaultsSettingsBuilder<T> Title(Action<ChartAxisDefaultsTitleSettingsBuilder<T>> configurator)
        {

            Container.Title.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsTitleSettingsBuilder<T>(Container.Title));

            return this;
        }

        /// <summary>
        /// If set to true the chart will display the axis. By default the axis is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartAxisDefaultsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
