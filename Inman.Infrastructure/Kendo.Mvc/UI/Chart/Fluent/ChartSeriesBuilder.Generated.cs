using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeries
    /// </summary>
    public partial class ChartSeriesBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The name of the value axis to use.
        /// </summary>
        /// <param name="value">The value for Axis</param>
        public ChartSeriesBuilder<T> Axis(string value)
        {
            Container.Axis = value;
            return this;
        }

        /// <summary>
        /// The border of the chart series.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesBuilder<T> Border(Action<ChartSeriesBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The name of the category axis to use for the series.The first axis will be used if no categoryAxis is specified.
        /// </summary>
        /// <param name="value">The value for CategoryAxis</param>
        public ChartSeriesBuilder<T> CategoryAxis(string value)
        {
            Container.CategoryAxis = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the category name or date.
        /// </summary>
        /// <param name="value">The value for CategoryField</param>
        public ChartSeriesBuilder<T> CategoryField(string value)
        {
            Container.CategoryField = value;
            return this;
        }

        /// <summary>
        /// The data field containing the close value.
        /// </summary>
        /// <param name="value">The value for CloseField</param>
        public ChartSeriesBuilder<T> CloseField(string value)
        {
            Container.CloseField = value;
            return this;
        }

        /// <summary>
        /// The series base color. The supported values are:
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The series base color. The supported values are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The series base color. The supported values are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The data item field which contains the series color.
        /// </summary>
        /// <param name="value">The value for ColorField</param>
        public ChartSeriesBuilder<T> ColorField(string value)
        {
            Container.ColorField = value;
            return this;
        }

        /// <summary>
        /// The label connectors options.
        /// </summary>
        /// <param name="configurator">The configurator for the connectors setting.</param>
        public ChartSeriesBuilder<T> Connectors(Action<ChartSeriesConnectorsSettingsBuilder<T>> configurator)
        {

            Container.Connectors.Chart = Container.Chart;
            configurator(new ChartSeriesConnectorsSettingsBuilder<T>(Container.Connectors));

            return this;
        }

        /// <summary>
        /// The data item field containing the current value.
        /// </summary>
        /// <param name="value">The value for CurrentField</param>
        public ChartSeriesBuilder<T> CurrentField(string value)
        {
            Container.CurrentField = value;
            return this;
        }

        /// <summary>
        /// The dash type of line chart.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartSeriesBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The series color when the open value is greater than the close value.
        /// </summary>
        /// <param name="value">The value for DownColor</param>
        public ChartSeriesBuilder<T> DownColor(string value)
        {
            Container.DownColorHandler = null;
            Container.DownColor = value;
            return this;
        }
        /// <summary>
        /// The series color when the open value is greater than the close value.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesBuilder<T> DownColorHandler(string handler)
        {
            Container.DownColor = null;
            Container.DownColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The series color when the open value is greater than the close value.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesBuilder<T> DownColorHandler(Func<object, object> handler)
        {
            Container.DownColor = null;
            Container.DownColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The data field containing the color applied when the open value is greater than the close value.
        /// </summary>
        /// <param name="value">The value for DownColorField</param>
        public ChartSeriesBuilder<T> DownColorField(string value)
        {
            Container.DownColorField = value;
            return this;
        }

        /// <summary>
        /// The space in pixels between the different segments of the funnel chart.
        /// </summary>
        /// <param name="value">The value for SegmentSpacing</param>
        public ChartSeriesBuilder<T> SegmentSpacing(double value)
        {
            Container.SegmentSpacing = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the summary type for waterfall series.
		/// Summary columns are optional and can be one of two types:
        /// </summary>
        /// <param name="value">The value for SummaryField</param>
        public ChartSeriesBuilder<T> SummaryField(string value)
        {
            Container.SummaryField = value;
            return this;
        }

        /// <summary>
        /// specifies the ratio top-base/bottom-base of the whole chart. neckRatio set to three means the top base is three times smaller than the bottom base.
        /// </summary>
        /// <param name="value">The value for NeckRatio</param>
        public ChartSeriesBuilder<T> NeckRatio(double value)
        {
            Container.NeckRatio = value;
            return this;
        }

        /// <summary>
        /// When set to true the ratio of the bases of each segment is calculated based on the ratio of currentDataItem.value/nextDataItem.value
		/// The last element is always created like a rectangle since there is no following element.
        /// </summary>
        /// <param name="value">The value for DynamicSlope</param>
        public ChartSeriesBuilder<T> DynamicSlope(bool value)
        {
            Container.DynamicSlope = value;
            return this;
        }

        /// <summary>
        /// When set to true the ratio of the bases of each segment is calculated based on the ratio of currentDataItem.value/nextDataItem.value
		/// The last element is always created like a rectangle since there is no following element.
        /// </summary>
        public ChartSeriesBuilder<T> DynamicSlope()
        {
            Container.DynamicSlope = true;
            return this;
        }

        /// <summary>
        /// When set to false all segments become with the same height, otherwise the height of each segment is based on its value.
        /// </summary>
        /// <param name="value">The value for DynamicHeight</param>
        public ChartSeriesBuilder<T> DynamicHeight(bool value)
        {
            Container.DynamicHeight = value;
            return this;
        }

        /// <summary>
        /// The error bars of the chart series.
        /// </summary>
        /// <param name="configurator">The configurator for the errorbars setting.</param>
        public ChartSeriesBuilder<T> ErrorBars(Action<ChartSeriesErrorBarsSettingsBuilder<T>> configurator)
        {

            Container.ErrorBars.Chart = Container.Chart;
            configurator(new ChartSeriesErrorBarsSettingsBuilder<T>(Container.ErrorBars));

            return this;
        }

        /// <summary>
        /// The data item field which contains the series.errorBars low value.
        /// </summary>
        /// <param name="value">The value for ErrorLowField</param>
        public ChartSeriesBuilder<T> ErrorLowField(string value)
        {
            Container.ErrorLowField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series.errorBars high value.
        /// </summary>
        /// <param name="value">The value for ErrorHighField</param>
        public ChartSeriesBuilder<T> ErrorHighField(string value)
        {
            Container.ErrorHighField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series.errorBars xAxis low value.
        /// </summary>
        /// <param name="value">The value for XErrorLowField</param>
        public ChartSeriesBuilder<T> XErrorLowField(string value)
        {
            Container.XErrorLowField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series.errorBars xAxis high value.
        /// </summary>
        /// <param name="value">The value for XErrorHighField</param>
        public ChartSeriesBuilder<T> XErrorHighField(string value)
        {
            Container.XErrorHighField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series.errorBars yAxis low value.
        /// </summary>
        /// <param name="value">The value for YErrorLowField</param>
        public ChartSeriesBuilder<T> YErrorLowField(string value)
        {
            Container.YErrorLowField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series.errorBars yAxis high value.
        /// </summary>
        /// <param name="value">The value for YErrorHighField</param>
        public ChartSeriesBuilder<T> YErrorHighField(string value)
        {
            Container.YErrorHighField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains a boolean value indicating whether the sector is exploded.
        /// </summary>
        /// <param name="value">The value for ExplodeField</param>
        public ChartSeriesBuilder<T> ExplodeField(string value)
        {
            Container.ExplodeField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series value.
        /// </summary>
        /// <param name="value">The value for Field</param>
        public ChartSeriesBuilder<T> Field(string value)
        {
            Container.Field = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series from value.
        /// </summary>
        /// <param name="value">The value for FromField</param>
        public ChartSeriesBuilder<T> FromField(string value)
        {
            Container.FromField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series to value.
        /// </summary>
        /// <param name="value">The value for ToField</param>
        public ChartSeriesBuilder<T> ToField(string value)
        {
            Container.ToField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series note text.
        /// </summary>
        /// <param name="value">The value for NoteTextField</param>
        public ChartSeriesBuilder<T> NoteTextField(string value)
        {
            Container.NoteTextField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series lower value.
        /// </summary>
        /// <param name="value">The value for LowerField</param>
        public ChartSeriesBuilder<T> LowerField(string value)
        {
            Container.LowerField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series q1 value.
        /// </summary>
        /// <param name="value">The value for Q1Field</param>
        public ChartSeriesBuilder<T> Q1Field(string value)
        {
            Container.Q1Field = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series median value.
        /// </summary>
        /// <param name="value">The value for MedianField</param>
        public ChartSeriesBuilder<T> MedianField(string value)
        {
            Container.MedianField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series q3 value.
        /// </summary>
        /// <param name="value">The value for Q3Field</param>
        public ChartSeriesBuilder<T> Q3Field(string value)
        {
            Container.Q3Field = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series upper value.
        /// </summary>
        /// <param name="value">The value for UpperField</param>
        public ChartSeriesBuilder<T> UpperField(string value)
        {
            Container.UpperField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series mean value.
        /// </summary>
        /// <param name="value">The value for MeanField</param>
        public ChartSeriesBuilder<T> MeanField(string value)
        {
            Container.MeanField = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the series outliers value.
        /// </summary>
        /// <param name="value">The value for OutliersField</param>
        public ChartSeriesBuilder<T> OutliersField(string value)
        {
            Container.OutliersField = value;
            return this;
        }

        /// <summary>
        /// The distance between categories expressed as a percentage of the bar width.See the related spacing setting.
        /// </summary>
        /// <param name="value">The value for Gap</param>
        public ChartSeriesBuilder<T> Gap(double value)
        {
            Container.Gap = value;
            return this;
        }

        /// <summary>
        /// The data field containing the high value.
        /// </summary>
        /// <param name="value">The value for HighField</param>
        public ChartSeriesBuilder<T> HighField(string value)
        {
            Container.HighField = value;
            return this;
        }

        /// <summary>
        /// The chart series highlighting configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the highlight setting.</param>
        public ChartSeriesBuilder<T> Highlight(Action<ChartSeriesHighlightSettingsBuilder<T>> configurator)
        {

            Container.Highlight.Chart = Container.Chart;
            configurator(new ChartSeriesHighlightSettingsBuilder<T>(Container.Highlight));

            return this;
        }

        /// <summary>
        /// The diameter of the donut hole in pixels.
        /// </summary>
        /// <param name="value">The value for HoleSize</param>
        public ChartSeriesBuilder<T> HoleSize(double value)
        {
            Container.HoleSize = value;
            return this;
        }

        /// <summary>
        /// The chart series label configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public ChartSeriesBuilder<T> Labels(Action<ChartSeriesLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

        /// <summary>
        /// The chart line configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartSeriesBuilder<T> Line(Action<ChartSeriesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartSeriesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The data field containing the low value.
        /// </summary>
        /// <param name="value">The value for LowField</param>
        public ChartSeriesBuilder<T> LowField(string value)
        {
            Container.LowField = value;
            return this;
        }

        /// <summary>
        /// The margin around each donut series (ring). A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartSeriesBuilder<T> Margin(Action<ChartSeriesMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartSeriesMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The chart series marker configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the markers setting.</param>
        public ChartSeriesBuilder<T> Markers(Action<ChartSeriesMarkersSettingsBuilder<T>> configurator)
        {

            Container.Markers.Chart = Container.Chart;
            configurator(new ChartSeriesMarkersSettingsBuilder<T>(Container.Markers));

            return this;
        }

        /// <summary>
        /// The chart series outliers configuration. Applies to mild outliers. Also check series.extremes.
        /// </summary>
        /// <param name="configurator">The configurator for the outliers setting.</param>
        public ChartSeriesBuilder<T> Outliers(Action<ChartSeriesOutliersSettingsBuilder<T>> configurator)
        {

            Container.Outliers.Chart = Container.Chart;
            configurator(new ChartSeriesOutliersSettingsBuilder<T>(Container.Outliers));

            return this;
        }

        /// <summary>
        /// The chart series extremes configuration. Applies to extreme outliers. Also check series.outliers.
        /// </summary>
        /// <param name="configurator">The configurator for the extremes setting.</param>
        public ChartSeriesBuilder<T> Extremes(Action<ChartSeriesExtremesSettingsBuilder<T>> configurator)
        {

            Container.Extremes.Chart = Container.Chart;
            configurator(new ChartSeriesExtremesSettingsBuilder<T>(Container.Extremes));

            return this;
        }

        /// <summary>
        /// The maximum size of the chart bubble series marker.
        /// </summary>
        /// <param name="value">The value for MaxSize</param>
        public ChartSeriesBuilder<T> MaxSize(double value)
        {
            Container.MaxSize = value;
            return this;
        }

        /// <summary>
        /// The minimum size of the chart bubble series marker.
        /// </summary>
        /// <param name="value">The value for MinSize</param>
        public ChartSeriesBuilder<T> MinSize(double value)
        {
            Container.MinSize = value;
            return this;
        }

        /// <summary>
        /// The name of the chart series which is visible in the legend.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public ChartSeriesBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The color to use for bar, column or waterfall series with negative values. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for NegativeColor</param>
        public ChartSeriesBuilder<T> NegativeColor(string value)
        {
            Container.NegativeColor = value;
            return this;
        }

        /// <summary>
        /// The options for displaying the chart negative bubble values.
        /// </summary>
        /// <param name="configurator">The configurator for the negativevalues setting.</param>
        public ChartSeriesBuilder<T> NegativeValues(Action<ChartSeriesNegativeValuesSettingsBuilder<T>> configurator)
        {

            Container.NegativeValues.Chart = Container.Chart;
            configurator(new ChartSeriesNegativeValuesSettingsBuilder<T>(Container.NegativeValues));

            return this;
        }

        /// <summary>
        /// The series opacity. By default the series are opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartSeriesBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The data field containing the open value.
        /// </summary>
        /// <param name="value">The value for OpenField</param>
        public ChartSeriesBuilder<T> OpenField(string value)
        {
            Container.OpenField = value;
            return this;
        }

        /// <summary>
        /// The chart series overlay options.
        /// </summary>
        /// <param name="configurator">The configurator for the overlay setting.</param>
        public ChartSeriesBuilder<T> Overlay(Action<ChartSeriesOverlaySettingsBuilder<T>> configurator)
        {

            Container.Overlay.Chart = Container.Chart;
            configurator(new ChartSeriesOverlaySettingsBuilder<T>(Container.Overlay));

            return this;
        }

        /// <summary>
        /// The padding around the chart (equal on all sides).
        /// </summary>
        /// <param name="value">The value for Padding</param>
        public ChartSeriesBuilder<T> Padding(double value)
        {
            Container.Padding = value;
            return this;
        }

        /// <summary>
        /// The or radius of the chart donut series in pixels. If not set, the available space is split evenly between the series.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartSeriesBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The data field containing the bubble size value.
        /// </summary>
        /// <param name="value">The value for SizeField</param>
        public ChartSeriesBuilder<T> SizeField(string value)
        {
            Container.SizeField = value;
            return this;
        }

        /// <summary>
        /// The distance between series points within a category. Expressed as a percentage of the bar width.See the related gap setting.
        /// </summary>
        /// <param name="value">The value for Spacing</param>
        public ChartSeriesBuilder<T> Spacing(double value)
        {
            Container.Spacing = value;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if the series should be stacked.
		/// A string value is interpreted as series.stack.group.
        /// </summary>
        /// <param name="configurator">The configurator for the stack setting.</param>
        public ChartSeriesBuilder<T> Stack(Action<ChartSeriesStackSettingsBuilder<T>> configurator)
        {
            Container.Stack.Enabled = true;

            Container.Stack.Chart = Container.Chart;
            configurator(new ChartSeriesStackSettingsBuilder<T>(Container.Stack));

            return this;
        }

        /// <summary>
        /// A boolean value indicating if the series should be stacked.
		/// A string value is interpreted as series.stack.group.
        /// </summary>
        public ChartSeriesBuilder<T> Stack()
        {
            Container.Stack.Enabled = true;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if the series should be stacked.
		/// A string value is interpreted as series.stack.group.
        /// </summary>
        /// <param name="enabled">Enables or disables the stack option.</param>
        public ChartSeriesBuilder<T> Stack(bool enabled)
        {
            Container.Stack.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The start angle (degrees) of the first donut or pie segment.Angles increase clockwise and zero is to the left. Negative values are acceptable.
        /// </summary>
        /// <param name="value">The value for StartAngle</param>
        public ChartSeriesBuilder<T> StartAngle(double value)
        {
            Container.StartAngle = value;
            return this;
        }

        /// <summary>
        /// The configuration options of the target
        /// </summary>
        /// <param name="configurator">The configurator for the target setting.</param>
        public ChartSeriesBuilder<T> Target(Action<ChartSeriesTargetSettingsBuilder<T>> configurator)
        {

            Container.Target.Chart = Container.Chart;
            configurator(new ChartSeriesTargetSettingsBuilder<T>(Container.Target));

            return this;
        }

        /// <summary>
        /// The data item field containing the target value.
        /// </summary>
        /// <param name="value">The value for TargetField</param>
        public ChartSeriesBuilder<T> TargetField(string value)
        {
            Container.TargetField = value;
            return this;
        }

        /// <summary>
        /// The chart series tooltip configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public ChartSeriesBuilder<T> Tooltip(Action<ChartSeriesTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.Chart = Container.Chart;
            configurator(new ChartSeriesTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// The type of the series.The supported values are:
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartSeriesBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// Sets the visible property of a chart series
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A value indicating whether to show the point category name (for funnel, donut and pie series)
		/// or series name (for other available series types) in the legend.
        /// </summary>
        /// <param name="value">The value for VisibleInLegend</param>
        public ChartSeriesBuilder<T> VisibleInLegend(bool value)
        {
            Container.VisibleInLegend = value;
            return this;
        }

        /// <summary>
        /// The data item field which indicates whether to show the point category name in the legend.
        /// </summary>
        /// <param name="value">The value for VisibleInLegendField</param>
        public ChartSeriesBuilder<T> VisibleInLegendField(string value)
        {
            Container.VisibleInLegendField = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the points. Applicable for bar, column, pie, donut, funnel, rangeBar, rangeColumn and waterfall series. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the points. Applicable for bar, column, pie, donut, funnel, rangeBar, rangeColumn and waterfall series. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// The line width.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The name of the X axis to use.For polar series the xAxis range is expressed in degrees.
        /// </summary>
        /// <param name="value">The value for XAxis</param>
        public ChartSeriesBuilder<T> XAxis(string value)
        {
            Container.XAxis = value;
            return this;
        }

        /// <summary>
        /// The data item field containing the X value.
        /// </summary>
        /// <param name="value">The value for XField</param>
        public ChartSeriesBuilder<T> XField(string value)
        {
            Container.XField = value;
            return this;
        }

        /// <summary>
        /// The name of the Y axis to use.** Available for bubble, scatter, scatterLine and polar series. **
        /// </summary>
        /// <param name="value">The value for YAxis</param>
        public ChartSeriesBuilder<T> YAxis(string value)
        {
            Container.YAxis = value;
            return this;
        }

        /// <summary>
        /// The data item field containing the Y value.
        /// </summary>
        /// <param name="value">The value for YField</param>
        public ChartSeriesBuilder<T> YField(string value)
        {
            Container.YField = value;
            return this;
        }

        /// <summary>
        /// The series notes configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the notes setting.</param>
        public ChartSeriesBuilder<T> Notes(Action<ChartSeriesNotesSettingsBuilder<T>> configurator)
        {

            Container.Notes.Chart = Container.Chart;
            configurator(new ChartSeriesNotesSettingsBuilder<T>(Container.Notes));

            return this;
        }

        /// <summary>
        /// An optional Z-index that can be used to change the default stacking order of series.The series with the highest Z-index will be placed on top.Series with no Z-index will use the default stacking order based on series type.
		/// For example line series will be on top with bar and area following below.
        /// </summary>
        /// <param name="value">The value for ZIndex</param>
        public ChartSeriesBuilder<T> ZIndex(double value)
        {
            Container.ZIndex = value;
            return this;
        }

        /// <summary>
        /// Specifies the preferred series aggregate.
        /// </summary>
        /// <param name="value">The value for Aggregate</param>
        public ChartSeriesBuilder<T> Aggregate(ChartSeriesAggregate value)
        {
            Container.AggregateHandler = null;
            Container.Aggregate = value;
            return this;
        }
        /// <summary>
        /// Specifies the preferred series aggregate.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesBuilder<T> AggregateHandler(string handler)
        {
            Container.Aggregate = null;
            Container.AggregateHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the preferred series aggregate.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesBuilder<T> AggregateHandler(Func<object, object> handler)
        {
            Container.Aggregate = null;
            Container.AggregateHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the behavior for handling missing values in the series.
        /// </summary>
        /// <param name="value">The value for MissingValues</param>
        public ChartSeriesBuilder<T> MissingValues(ChartSeriesMissingValues value)
        {
            Container.MissingValues = value;
            return this;
        }

        /// <summary>
        /// Specifies the preferred rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        public ChartSeriesBuilder<T> Style(ChartSeriesStyle value)
        {
            Container.Style = value;
            return this;
        }

    }
}
