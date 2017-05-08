using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Tooltip for ASP.NET MVC events.
    /// </summary>
    public class TooltipEventBuilder: EventBuilder
    {
        public TooltipEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when an AJAX request for content completes.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the contentLoad event.</param>
        public TooltipEventBuilder ContentLoad(string handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request for content completes.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TooltipEventBuilder ContentLoad(Func<object, object> handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Tooltip is shown.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the show event.</param>
        public TooltipEventBuilder Show(string handler)
        {
            Handler("show", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Tooltip is shown.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TooltipEventBuilder Show(Func<object, object> handler)
        {
            Handler("show", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Tooltip is hidden
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the hide event.</param>
        public TooltipEventBuilder Hide(string handler)
        {
            Handler("hide", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a Tooltip is hidden
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TooltipEventBuilder Hide(Func<object, object> handler)
        {
            Handler("hide", handler);

            return this;
        }

        /// <summary>
        /// Triggered before an AJAX request started. Note that this event is triggered only when an AJAX request, instead of an iframe, is used.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the requestStart event.</param>
        public TooltipEventBuilder RequestStart(string handler)
        {
            Handler("requestStart", handler);

            return this;
        }

        /// <summary>
        /// Triggered before an AJAX request started. Note that this event is triggered only when an AJAX request, instead of an iframe, is used.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TooltipEventBuilder RequestStart(Func<object, object> handler)
        {
            Handler("requestStart", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request for content fails.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public TooltipEventBuilder Error(string handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an AJAX request for content fails.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TooltipEventBuilder Error(Func<object, object> handler)
        {
            Handler("error", handler);

            return this;
        }

    }
}

