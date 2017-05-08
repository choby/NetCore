using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Chart
    /// </summary>
    public partial class ChartBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public ChartBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// The default options for all chart axes. Accepts the options supported by categoryAxis, valueAxis, xAxis and yAxis.
        /// </summary>
        /// <param name="configurator">The configurator for the axisdefaults setting.</param>
        public ChartBuilder<T> AxisDefaults(Action<ChartAxisDefaultsSettingsBuilder<T>> configurator)
        {

            Container.AxisDefaults.Chart = Container;
            configurator(new ChartAxisDefaultsSettingsBuilder<T>(Container.AxisDefaults));

            return this;
        }

        /// <summary>
        /// The chart area configuration options. Represents the entire visible area of the chart.
        /// </summary>
        /// <param name="configurator">The configurator for the chartarea setting.</param>
        public ChartBuilder<T> ChartArea(Action<ChartChartAreaSettingsBuilder<T>> configurator)
        {

            Container.ChartArea.Chart = Container;
            configurator(new ChartChartAreaSettingsBuilder<T>(Container.ChartArea));

            return this;
        }

        /// <summary>
        /// The chart legend configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the legend setting.</param>
        public ChartBuilder<T> Legend(Action<ChartLegendSettingsBuilder<T>> configurator)
        {

            Container.Legend.Chart = Container;
            configurator(new ChartLegendSettingsBuilder<T>(Container.Legend));

            return this;
        }

        /// <summary>
        /// The chart panes configuration.Panes are used to split the chart in two or more parts. The panes are ordered from top to bottom.Each axis can be associated with a pane by setting its pane option to the name of the desired pane.
		/// Axis that don't have specified pane are placed in the top (default) pane.Series are moved to the desired pane by associating them with an axis.
        /// </summary>
        /// <param name="configurator">The configurator for the panes setting.</param>
        public ChartBuilder<T> Panes(Action<ChartPaneFactory<T>> configurator)
        {

            configurator(new ChartPaneFactory<T>(Container.Panes)
            {
                Chart = Container
            });

            return this;
        }

        /// <summary>
        /// Specifies if the chart can be panned.
        /// </summary>
        /// <param name="configurator">The configurator for the pannable setting.</param>
        public ChartBuilder<T> Pannable(Action<ChartPannableSettingsBuilder<T>> configurator)
        {
            Container.Pannable.Enabled = true;

            Container.Pannable.Chart = Container;
            configurator(new ChartPannableSettingsBuilder<T>(Container.Pannable));

            return this;
        }

        /// <summary>
        /// Specifies if the chart can be panned.
        /// </summary>
        public ChartBuilder<T> Pannable()
        {
            Container.Pannable.Enabled = true;
            return this;
        }

        /// <summary>
        /// Specifies if the chart can be panned.
        /// </summary>
        /// <param name="enabled">Enables or disables the pannable option.</param>
        public ChartBuilder<T> Pannable(bool enabled)
        {
            Container.Pannable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Configures the export settings for the saveAsPDF method.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public ChartBuilder<T> Pdf(Action<ChartPdfSettingsBuilder<T>> configurator)
        {

            Container.Pdf.Chart = Container;
            configurator(new ChartPdfSettingsBuilder<T>(Container.Pdf));

            return this;
        }

        /// <summary>
        /// The plot area configuration options. The plot area is the area which displays the series.
        /// </summary>
        /// <param name="configurator">The configurator for the plotarea setting.</param>
        public ChartBuilder<T> PlotArea(Action<ChartPlotAreaSettingsBuilder<T>> configurator)
        {

            Container.PlotArea.Chart = Container;
            configurator(new ChartPlotAreaSettingsBuilder<T>(Container.PlotArea));

            return this;
        }

        /// <summary>
        /// The configuration of the chart series.The series type is determined by the value of the type field.
		/// If a type value is missing, the type is assumed to be the one specified in seriesDefaults.
        /// </summary>
        /// <param name="configurator">The configurator for the series setting.</param>
        public ChartBuilder<T> Series(Action<ChartSeriesFactory<T>> configurator)
        {

            configurator(new ChartSeriesFactory<T>(Container.Series)
            {
                Chart = Container
            });

            return this;
        }

        /// <summary>
        /// The default colors for the chart's series. When all colors are used, new colors are pulled from the start again.
        /// </summary>
        /// <param name="value">The value for SeriesColors</param>
        public ChartBuilder<T> SeriesColors(params String[] value)
        {
            Container.SeriesColors = value;
            return this;
        }

        /// <summary>
        /// The chart theme.The supported values are:
        /// </summary>
        /// <param name="value">The value for Theme</param>
        public ChartBuilder<T> Theme(string value)
        {
            Container.Theme = value;
            return this;
        }

        /// <summary>
        /// The chart title configuration options or text.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public ChartBuilder<T> Title(Action<ChartTitleSettingsBuilder<T>> configurator)
        {

            Container.Title.Chart = Container;
            configurator(new ChartTitleSettingsBuilder<T>(Container.Title));

            return this;
        }

        /// <summary>
        /// The chart series tooltip configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public ChartBuilder<T> Tooltip(Action<ChartTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.Chart = Container;
            configurator(new ChartTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// If set to true the chart will play animations when displaying the series. By default animations are enabled.
        /// </summary>
        /// <param name="value">The value for Transitions</param>
        public ChartBuilder<T> Transitions(bool value)
        {
            Container.Transitions = value;
            return this;
        }

        /// <summary>
        /// Specifies if the chart can be zoomed.
        /// </summary>
        /// <param name="configurator">The configurator for the zoomable setting.</param>
        public ChartBuilder<T> Zoomable(Action<ChartZoomableSettingsBuilder<T>> configurator)
        {
            Container.Zoomable.Enabled = true;

            Container.Zoomable.Chart = Container;
            configurator(new ChartZoomableSettingsBuilder<T>(Container.Zoomable));

            return this;
        }

        /// <summary>
        /// Specifies if the chart can be zoomed.
        /// </summary>
        public ChartBuilder<T> Zoomable()
        {
            Container.Zoomable.Enabled = true;
            return this;
        }

        /// <summary>
        /// Specifies if the chart can be zoomed.
        /// </summary>
        /// <param name="enabled">Enables or disables the zoomable option.</param>
        public ChartBuilder<T> Zoomable(bool enabled)
        {
            Container.Zoomable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Specifies the preferred widget rendering mode.
        /// </summary>
        /// <param name="value">The value for RenderAs</param>
        public ChartBuilder<T> RenderAs(RenderingMode value)
        {
            Container.RenderAs = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart()
        ///       .Name("Chart")
        ///       .Events(events => events
        ///           .AxisLabelClick("onAxisLabelClick")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ChartBuilder<T> Events(Action<ChartEventBuilder> configurator)
        {
            configurator(new ChartEventBuilder(Container.Events));
            return this;
        }
        
    }
}

