using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI StockChart for ASP.NET MVC events.
    /// </summary>
    public class StockChartEventBuilder: EventBuilder
    {
        public StockChartEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when an axis label is clicked.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the axisLabelClick event.</param>
        public StockChartEventBuilder AxisLabelClick(string handler)
        {
            Handler("axisLabelClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when an axis label is clicked.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder AxisLabelClick(Func<object, object> handler)
        {
            Handler("axisLabelClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when the chart has received data from the data source\n\t\t/// and is about to render it.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public StockChartEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fires when the chart has received data from the data source\n\t\t/// and is about to render it.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mouse or a swipe gesture to drag the chart.The drag operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragStart event.</param>
        public StockChartEventBuilder DragStart(string handler)
        {
            Handler("dragStart", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mouse or a swipe gesture to drag the chart.The drag operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder DragStart(Func<object, object> handler)
        {
            Handler("dragStart", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is dragging the chart using the mouse or swipe gestures.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drag event.</param>
        public StockChartEventBuilder Drag(string handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is dragging the chart using the mouse or swipe gestures.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder Drag(Func<object, object> handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops dragging the chart.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragEnd event.</param>
        public StockChartEventBuilder DragEnd(string handler)
        {
            Handler("dragEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops dragging the chart.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder DragEnd(Func<object, object> handler)
        {
            Handler("dragEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is clicked, before the selected series visibility is toggled.\n\t\t/// Can be cancelled.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the legendItemClick event.</param>
        public StockChartEventBuilder LegendItemClick(string handler)
        {
            Handler("legendItemClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is clicked, before the selected series visibility is toggled.\n\t\t/// Can be cancelled.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder LegendItemClick(Func<object, object> handler)
        {
            Handler("legendItemClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is hovered.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the legendItemHover event.</param>
        public StockChartEventBuilder LegendItemHover(string handler)
        {
            Handler("legendItemHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when an legend item is hovered.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder LegendItemHover(Func<object, object> handler)
        {
            Handler("legendItemHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the noteClick event.</param>
        public StockChartEventBuilder NoteClick(string handler)
        {
            Handler("noteClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder NoteClick(Func<object, object> handler)
        {
            Handler("noteClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the noteHover event.</param>
        public StockChartEventBuilder NoteHover(string handler)
        {
            Handler("noteHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers one of the notes.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder NoteHover(Func<object, object> handler)
        {
            Handler("noteHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when plot area is clicked.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the plotAreaClick event.</param>
        public StockChartEventBuilder PlotAreaClick(string handler)
        {
            Handler("plotAreaClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when plot area is clicked.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder PlotAreaClick(Func<object, object> handler)
        {
            Handler("plotAreaClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers the plot area.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the plotAreaHover event.</param>
        public StockChartEventBuilder PlotAreaHover(string handler)
        {
            Handler("plotAreaHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user hovers the plot area.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder PlotAreaHover(Func<object, object> handler)
        {
            Handler("plotAreaHover", handler);

            return this;
        }

        /// <summary>
        /// Fired when the chart is ready to render on screen.Can be used, for example, to remove loading indicators. Changes to options will be ignored.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the render event.</param>
        public StockChartEventBuilder Render(string handler)
        {
            Handler("render", handler);

            return this;
        }

        /// <summary>
        /// Fired when the chart is ready to render on screen.Can be used, for example, to remove loading indicators. Changes to options will be ignored.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder Render(Func<object, object> handler)
        {
            Handler("render", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user modifies the selection.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public StockChartEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user modifies the selection.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user completes modifying the selection.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the selectEnd event.</param>
        public StockChartEventBuilder SelectEnd(string handler)
        {
            Handler("selectEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user completes modifying the selection.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder SelectEnd(Func<object, object> handler)
        {
            Handler("selectEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts modifying the axis selection.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the selectStart event.</param>
        public StockChartEventBuilder SelectStart(string handler)
        {
            Handler("selectStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts modifying the axis selection.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder SelectStart(Func<object, object> handler)
        {
            Handler("selectStart", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are clicked.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the seriesClick event.</param>
        public StockChartEventBuilder SeriesClick(string handler)
        {
            Handler("seriesClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are clicked.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder SeriesClick(Func<object, object> handler)
        {
            Handler("seriesClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are hovered.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the seriesHover event.</param>
        public StockChartEventBuilder SeriesHover(string handler)
        {
            Handler("seriesHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are hovered.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder SeriesHover(Func<object, object> handler)
        {
            Handler("seriesHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mousewheel to zoom the chart.The zoom operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomStart event.</param>
        public StockChartEventBuilder ZoomStart(string handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mousewheel to zoom the chart.The zoom operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder ZoomStart(Func<object, object> handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is zooming the chart using the mousewheel.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoom event.</param>
        public StockChartEventBuilder Zoom(string handler)
        {
            Handler("zoom", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is zooming the chart using the mousewheel.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder Zoom(Func<object, object> handler)
        {
            Handler("zoom", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops zooming the chart.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomEnd event.</param>
        public StockChartEventBuilder ZoomEnd(string handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops zooming the chart.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public StockChartEventBuilder ZoomEnd(Func<object, object> handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

    }
}

