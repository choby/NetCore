using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Map for ASP.NET MVC events.
    /// </summary>
    public class MapEventBuilder: EventBuilder
    {
        public MapEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired immediately before the map is reset.\n\t\t/// This event is typically used for cleanup by layer implementers.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the beforeReset event.</param>
        public MapEventBuilder BeforeReset(string handler)
        {
            Handler("beforeReset", handler);

            return this;
        }

        /// <summary>
        /// Fired immediately before the map is reset.\n\t\t/// This event is typically used for cleanup by layer implementers.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder BeforeReset(Func<object, object> handler)
        {
            Handler("beforeReset", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks on the map.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the click event.</param>
        public MapEventBuilder Click(string handler)
        {
            Handler("click", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks on the map.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder Click(Func<object, object> handler)
        {
            Handler("click", handler);

            return this;
        }

        /// <summary>
        /// Fired when a marker has been displayed and has a DOM element assigned.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the markerActivate event.</param>
        public MapEventBuilder MarkerActivate(string handler)
        {
            Handler("markerActivate", handler);

            return this;
        }

        /// <summary>
        /// Fired when a marker has been displayed and has a DOM element assigned.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder MarkerActivate(Func<object, object> handler)
        {
            Handler("markerActivate", handler);

            return this;
        }

        /// <summary>
        /// Fired when a marker has been created and is about to be displayed.\n\t\t/// Cancelling the event will prevent the marker from being shown.Use markerActivate if you need to access the marker DOM element.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the markerCreated event.</param>
        public MapEventBuilder MarkerCreated(string handler)
        {
            Handler("markerCreated", handler);

            return this;
        }

        /// <summary>
        /// Fired when a marker has been created and is about to be displayed.\n\t\t/// Cancelling the event will prevent the marker from being shown.Use markerActivate if you need to access the marker DOM element.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder MarkerCreated(Func<object, object> handler)
        {
            Handler("markerCreated", handler);

            return this;
        }

        /// <summary>
        /// Fired when a marker has been clicked or tapped.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the markerClick event.</param>
        public MapEventBuilder MarkerClick(string handler)
        {
            Handler("markerClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when a marker has been clicked or tapped.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder MarkerClick(Func<object, object> handler)
        {
            Handler("markerClick", handler);

            return this;
        }

        /// <summary>
        /// Fired while the map viewport is being moved.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pan event.</param>
        public MapEventBuilder Pan(string handler)
        {
            Handler("pan", handler);

            return this;
        }

        /// <summary>
        /// Fired while the map viewport is being moved.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder Pan(Func<object, object> handler)
        {
            Handler("pan", handler);

            return this;
        }

        /// <summary>
        /// Fires after the map viewport has been moved.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the panEnd event.</param>
        public MapEventBuilder PanEnd(string handler)
        {
            Handler("panEnd", handler);

            return this;
        }

        /// <summary>
        /// Fires after the map viewport has been moved.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder PanEnd(Func<object, object> handler)
        {
            Handler("panEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the map is reset.\n\t\t/// This typically occurs on initial load and after a zoom/center change.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the reset event.</param>
        public MapEventBuilder Reset(string handler)
        {
            Handler("reset", handler);

            return this;
        }

        /// <summary>
        /// Fired when the map is reset.\n\t\t/// This typically occurs on initial load and after a zoom/center change.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder Reset(Func<object, object> handler)
        {
            Handler("reset", handler);

            return this;
        }

        /// <summary>
        /// Fired when a shape is clicked or tapped.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the shapeClick event.</param>
        public MapEventBuilder ShapeClick(string handler)
        {
            Handler("shapeClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when a shape is clicked or tapped.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ShapeClick(Func<object, object> handler)
        {
            Handler("shapeClick", handler);

            return this;
        }

        /// <summary>
        /// Fired when a shape is created, but is not rendered yet.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the shapeCreated event.</param>
        public MapEventBuilder ShapeCreated(string handler)
        {
            Handler("shapeCreated", handler);

            return this;
        }

        /// <summary>
        /// Fired when a shape is created, but is not rendered yet.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ShapeCreated(Func<object, object> handler)
        {
            Handler("shapeCreated", handler);

            return this;
        }

        /// <summary>
        /// Fired when a GeoJSON Feature is created on a shape layer.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the shapeFeatureCreated event.</param>
        public MapEventBuilder ShapeFeatureCreated(string handler)
        {
            Handler("shapeFeatureCreated", handler);

            return this;
        }

        /// <summary>
        /// Fired when a GeoJSON Feature is created on a shape layer.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ShapeFeatureCreated(Func<object, object> handler)
        {
            Handler("shapeFeatureCreated", handler);

            return this;
        }

        /// <summary>
        /// Fired when the mouse enters a shape.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the shapeMouseEnter event.</param>
        public MapEventBuilder ShapeMouseEnter(string handler)
        {
            Handler("shapeMouseEnter", handler);

            return this;
        }

        /// <summary>
        /// Fired when the mouse enters a shape.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ShapeMouseEnter(Func<object, object> handler)
        {
            Handler("shapeMouseEnter", handler);

            return this;
        }

        /// <summary>
        /// Fired when the mouse leaves a shape.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the shapeMouseLeave event.</param>
        public MapEventBuilder ShapeMouseLeave(string handler)
        {
            Handler("shapeMouseLeave", handler);

            return this;
        }

        /// <summary>
        /// Fired when the mouse leaves a shape.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ShapeMouseLeave(Func<object, object> handler)
        {
            Handler("shapeMouseLeave", handler);

            return this;
        }

        /// <summary>
        /// Fired when the map zoom level is about to change.\n\t\t/// Cancelling the event will prevent the user action.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomStart event.</param>
        public MapEventBuilder ZoomStart(string handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the map zoom level is about to change.\n\t\t/// Cancelling the event will prevent the user action.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ZoomStart(Func<object, object> handler)
        {
            Handler("zoomStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the map zoom level has changed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the zoomEnd event.</param>
        public MapEventBuilder ZoomEnd(string handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the map zoom level has changed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MapEventBuilder ZoomEnd(Func<object, object> handler)
        {
            Handler("zoomEnd", handler);

            return this;
        }

    }
}

