using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TabStrip for ASP.NET MVC events.
    /// </summary>
    public class TabStripEventBuilder: EventBuilder
    {
        public TabStripEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered after a tab is being made visible and its animation complete. Before Q2 2014 this event was invoked after tab show, but before the end of the animation. This event is triggered only for tabs with associated content.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the activate event.</param>
        public TabStripEventBuilder Activate(string handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Triggered after a tab is being made visible and its animation complete. Before Q2 2014 this event was invoked after tab show, but before the end of the animation. This event is triggered only for tabs with associated content.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TabStripEventBuilder Activate(Func<object, object> handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when content is fetched from an AJAX request.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the contentLoad event.</param>
        public TabStripEventBuilder ContentLoad(string handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered when content is fetched from an AJAX request.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TabStripEventBuilder ContentLoad(Func<object, object> handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request results in an error.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public TabStripEventBuilder Error(string handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request results in an error.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TabStripEventBuilder Error(Func<object, object> handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered before a tab is selected.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public TabStripEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered before a tab is selected.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TabStripEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered just after a tab is being made visible, but before the end of the animation. Before Q2 2014 this event was called activate.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the show event.</param>
        public TabStripEventBuilder Show(string handler)
        {
            Handler("show", handler);

            return this;
        }

        /// <summary>
        /// Triggered just after a tab is being made visible, but before the end of the animation. Before Q2 2014 this event was called activate.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TabStripEventBuilder Show(Func<object, object> handler)
        {
            Handler("show", handler);

            return this;
        }

    }
}

