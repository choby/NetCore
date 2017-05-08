using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Window for ASP.NET MVC events.
    /// </summary>
    public class WindowEventBuilder: EventBuilder
    {
        public WindowEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when a Window has finished its opening animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the activate event.</param>
        public WindowEventBuilder Activate(string handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window has finished its opening animation.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Activate(Func<object, object> handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window is closed (by a user or through the close() method).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public WindowEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window is closed (by a user or through the close() method).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window has finished its closing animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the deactivate event.</param>
        public WindowEventBuilder Deactivate(string handler)
        {
            Handler("deactivate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window has finished its closing animation.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Deactivate(Func<object, object> handler)
        {
            Handler("deactivate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window has been moved by a user.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragend event.</param>
        public WindowEventBuilder DragEnd(string handler)
        {
            Handler("dragend", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window has been moved by a user.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder DragEnd(Func<object, object> handler)
        {
            Handler("dragend", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the user starts to move the window.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragstart event.</param>
        public WindowEventBuilder DragStart(string handler)
        {
            Handler("dragstart", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the user starts to move the window.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder DragStart(Func<object, object> handler)
        {
            Handler("dragstart", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request for content fails.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public WindowEventBuilder Error(string handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request for content fails.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Error(Func<object, object> handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the window has been minimized by the user. Introduced in 2016.Q1.SP1
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the maximize event.</param>
        public WindowEventBuilder Maximize(string handler)
        {
            Handler("maximize", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the window has been minimized by the user. Introduced in 2016.Q1.SP1
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Maximize(Func<object, object> handler)
        {
            Handler("maximize", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the window has been minimized by the user. Introduced in 2016.Q1.SP1
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the minimize event.</param>
        public WindowEventBuilder Minimize(string handler)
        {
            Handler("minimize", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the window has been minimized by the user. Introduced in 2016.Q1.SP1
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Minimize(Func<object, object> handler)
        {
            Handler("minimize", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window is opened (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public WindowEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Window is opened (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the content of a Window has finished loading via AJAX,\n\t\t/// when the window iframe has finished loading, or when the refresh button\n\t\t/// has been clicked on a window with static content.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the refresh event.</param>
        public WindowEventBuilder Refresh(string handler)
        {
            Handler("refresh", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the content of a Window has finished loading via AJAX,\n\t\t/// when the window iframe has finished loading, or when the refresh button\n\t\t/// has been clicked on a window with static content.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Refresh(Func<object, object> handler)
        {
            Handler("refresh", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a window has been resized by a user.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resize event.</param>
        public WindowEventBuilder Resize(string handler)
        {
            Handler("resize", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a window has been resized by a user.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public WindowEventBuilder Resize(Func<object, object> handler)
        {
            Handler("resize", handler);

            return this;
        }

    }
}

