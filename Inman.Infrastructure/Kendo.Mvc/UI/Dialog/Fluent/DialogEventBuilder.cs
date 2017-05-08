using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Dialog for ASP.NET MVC events.
    /// </summary>
    public class DialogEventBuilder: EventBuilder
    {
        public DialogEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when a Dialog is closed (by a user or through the close() method).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public DialogEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog is closed (by a user or through the close() method).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DialogEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog has finished its closing animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the hide event.</param>
        public DialogEventBuilder Hide(string handler)
        {
            Handler("hide", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog has finished its closing animation.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DialogEventBuilder Hide(Func<object, object> handler)
        {
            Handler("hide", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog is opened for the first time (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the initOpen event.</param>
        public DialogEventBuilder InitOpen(string handler)
        {
            Handler("initOpen", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog is opened for the first time (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DialogEventBuilder InitOpen(Func<object, object> handler)
        {
            Handler("initOpen", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog is opened (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public DialogEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog is opened (i.e. the open() method is called).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DialogEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog has finished its opening animation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the show event.</param>
        public DialogEventBuilder Show(string handler)
        {
            Handler("show", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Dialog has finished its opening animation.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DialogEventBuilder Show(Func<object, object> handler)
        {
            Handler("show", handler);

            return this;
        }

    }
}

