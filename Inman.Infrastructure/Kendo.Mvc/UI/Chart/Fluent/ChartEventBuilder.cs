using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Chart for ASP.NET MVC events.
    /// </summary>
    public class ChartEventBuilder: EventBuilder
    {
        public ChartEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when the user clicks an axis label.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the axisLabelClick event.</param>
        public ChartEventBuilder AxisLabelClick(string handler)
        {
            Handler("axisLabelClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks an axis label.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder AxisLabelClick(Func<object, object> handler)
        {
            Handler("axisLabelClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public ChartEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired as long as the user is dragging the chart using the mouse or swipe gestures.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drag event.</param>
        public ChartEventBuilder Drag(string handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Fired as long as the user is dragging the chart using the mouse or swipe gestures.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder Drag(Func<object, object> handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user stops dragging the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragEnd event.</param>
        public ChartEventBuilder DragEnd(string handler)
        {
            Handler("dragEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user stops dragging the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder DragEnd(Func<object, object> handler)
        {
            Handler("dragEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts dragging the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragStart event.</param>
        public ChartEventBuilder DragStart(string handler)
        {
            Handler("dragStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts dragging the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder DragStart(Func<object, object> handler)
        {
            Handler("dragStart", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is clicked, before the selected series visibility is toggled.\n\t\t/// Can be cancelled.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the legendItemClick event.</param>
        public ChartEventBuilder LegendItemClick(string handler)
        {
            Handler("legendItemClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is clicked, before the selected series visibility is toggled.\n\t\t/// Can be cancelled.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder LegendItemClick(Func<object, object> handler)
        {
            Handler("legendItemClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is hovered.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the legendItemHover event.</param>
        public ChartEventBuilder LegendItemHover(string handler)
        {
            Handler("legendItemHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is hovered.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder LegendItemHover(Func<object, object> handler)
        {
            Handler("legendItemHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the noteClick event.</param>
        public ChartEventBuilder NoteClick(string handler)
        {
            Handler("noteClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder NoteClick(Func<object, object> handler)
        {
            Handler("noteClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the noteHover event.</param>
        public ChartEventBuilder NoteHover(string handler)
        {
            Handler("noteHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder NoteHover(Func<object, object> handler)
        {
            Handler("noteHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the plot area.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the plotAreaClick event.</param>
        public ChartEventBuilder PlotAreaClick(string handler)
        {
            Handler("plotAreaClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the plot area.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder PlotAreaClick(Func<object, object> handler)
        {
            Handler("plotAreaClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers the plot area.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the plotAreaHover event.</param>
        public ChartEventBuilder PlotAreaHover(string handler)
        {
            Handler("plotAreaHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers the plot area.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder PlotAreaHover(Func<object, object> handler)
        {
            Handler("plotAreaHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the chart is ready to render on screen.Can be used, for example, to remove loading indicators. Changes to options will be ignored.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the render event.</param>
        public ChartEventBuilder Render(string handler)
        {
            Handler("render", handler);

            return this;
        }

        /// <summary>
        /// Fired when the chart is ready to render on screen.Can be used, for example, to remove loading indicators. Changes to options will be ignored.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder Render(Func<object, object> handler)
        {
            Handler("render", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user modifies the selection.The range units are:The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public ChartEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user modifies the selection.The range units are:The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user completes modifying the selection.The range units are:The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the selectEnd event.</param>
        public ChartEventBuilder SelectEnd(string handler)
        {
            Handler("selectEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user completes modifying the selection.The range units are:The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder SelectEnd(Func<object, object> handler)
        {
            Handler("selectEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts modifying the axis selection.The range units are:The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the selectStart event.</param>
        public ChartEventBuilder SelectStart(string handler)
        {
            Handler("selectStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts modifying the axis selection.The range units are:The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder SelectStart(Func<object, object> handler)
        {
            Handler("selectStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the chart series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the seriesClick event.</param>
        public ChartEventBuilder SeriesClick(string handler)
        {
            Handler("seriesClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the chart series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder SeriesClick(Func<object, object> handler)
        {
            Handler("seriesClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers the chart series.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the seriesHover event.</param>
        public ChartEventBuilder SeriesHover(string handler)
        {
            Handler("seriesHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers the chart series.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder SeriesHover(Func<object, object> handler)
        {
            Handler("seriesHover", handler);

            return this;
        }

        /// <summary>
        /// Fired as long as the user is zooming the chart using the mousewheel.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoom event.</param>
        public ChartEventBuilder Zoom(string handler)
        {
            Handler("zoom", handler);

            return this;
        }

        /// <summary>
        /// Fired as long as the user is zooming the chart using the mousewheel.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder Zoom(Func<object, object> handler)
        {
            Handler("zoom", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user stops zooming the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomEnd event.</param>
        public ChartEventBuilder ZoomEnd(string handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user stops zooming the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder ZoomEnd(Func<object, object> handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user uses the mousewheel to zoom the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomStart event.</param>
        public ChartEventBuilder ZoomStart(string handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user uses the mousewheel to zoom the chart.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartEventBuilder ZoomStart(Func<object, object> handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

    }
}

