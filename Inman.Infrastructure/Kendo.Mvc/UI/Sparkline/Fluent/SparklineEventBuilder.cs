using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Sparkline for ASP.NET MVC events.
    /// </summary>
    public class SparklineEventBuilder: EventBuilder
    {
        public SparklineEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when an axis label is clicked.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the axisLabelClick event.</param>
        public SparklineEventBuilder AxisLabelClick(string handler)
        {
            Handler("axisLabelClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when an axis label is clicked.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder AxisLabelClick(Func<object, object> handler)
        {
            Handler("axisLabelClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when the sparkline has received data from the data source\n\t\t/// and is about to render it.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public SparklineEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fires when the sparkline has received data from the data source\n\t\t/// and is about to render it.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mouse or a swipe gesture to drag the sparkline.The drag operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragStart event.</param>
        public SparklineEventBuilder DragStart(string handler)
        {
            Handler("dragStart", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mouse or a swipe gesture to drag the sparkline.The drag operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder DragStart(Func<object, object> handler)
        {
            Handler("dragStart", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is dragging the sparkline using the mouse or swipe gestures.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drag event.</param>
        public SparklineEventBuilder Drag(string handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is dragging the sparkline using the mouse or swipe gestures.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder Drag(Func<object, object> handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops dragging the sparkline.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragEnd event.</param>
        public SparklineEventBuilder DragEnd(string handler)
        {
            Handler("dragEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops dragging the sparkline.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder DragEnd(Func<object, object> handler)
        {
            Handler("dragEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires when plot area is clicked.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the plotAreaClick event.</param>
        public SparklineEventBuilder PlotAreaClick(string handler)
        {
            Handler("plotAreaClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when plot area is clicked.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder PlotAreaClick(Func<object, object> handler)
        {
            Handler("plotAreaClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are clicked.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the seriesClick event.</param>
        public SparklineEventBuilder SeriesClick(string handler)
        {
            Handler("seriesClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are clicked.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder SeriesClick(Func<object, object> handler)
        {
            Handler("seriesClick", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are hovered.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the seriesHover event.</param>
        public SparklineEventBuilder SeriesHover(string handler)
        {
            Handler("seriesHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when chart series are hovered.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder SeriesHover(Func<object, object> handler)
        {
            Handler("seriesHover", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mousewheel to zoom the chart.The zoom operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomStart event.</param>
        public SparklineEventBuilder ZoomStart(string handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user has used the mousewheel to zoom the chart.The zoom operation can be aborted by calling e.preventDefault().
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder ZoomStart(Func<object, object> handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is zooming the chart using the mousewheel.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoom event.</param>
        public SparklineEventBuilder Zoom(string handler)
        {
            Handler("zoom", handler);

            return this;
        }

        /// <summary>
        /// Fires as long as the user is zooming the chart using the mousewheel.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder Zoom(Func<object, object> handler)
        {
            Handler("zoom", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops zooming the chart.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomEnd event.</param>
        public SparklineEventBuilder ZoomEnd(string handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user stops zooming the chart.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SparklineEventBuilder ZoomEnd(Func<object, object> handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

    }
}

