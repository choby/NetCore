using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Splitter for ASP.NET MVC events.
    /// </summary>
    public class SplitterEventBuilder: EventBuilder
    {
        public SplitterEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when a pane of a Splitter is collapsed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapse event.</param>
        public SplitterEventBuilder Collapse(string handler)
        {
            Handler("collapse", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a pane of a Splitter is collapsed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SplitterEventBuilder Collapse(Func<object, object> handler)
        {
            Handler("collapse", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the content for a pane has finished loading.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the contentLoad event.</param>
        public SplitterEventBuilder ContentLoad(string handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the content for a pane has finished loading.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SplitterEventBuilder ContentLoad(Func<object, object> handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the AJAX request that fetches a pane content has failed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public SplitterEventBuilder Error(string handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the AJAX request that fetches a pane content has failed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SplitterEventBuilder Error(Func<object, object> handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a pane of a Splitter is expanded.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expand event.</param>
        public SplitterEventBuilder Expand(string handler)
        {
            Handler("expand", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a pane of a Splitter is expanded.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SplitterEventBuilder Expand(Func<object, object> handler)
        {
            Handler("expand", handler);

            return this;
        }

        /// <summary>
        /// This event is now obsolete and will be removed in the future. Please use the resize event instead.Fires when the splitter layout has changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the layoutChange event.</param>
        public SplitterEventBuilder LayoutChange(string handler)
        {
            Handler("layoutChange", handler);

            return this;
        }

        /// <summary>
        /// This event is now obsolete and will be removed in the future. Please use the resize event instead.Fires when the splitter layout has changed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SplitterEventBuilder LayoutChange(Func<object, object> handler)
        {
            Handler("layoutChange", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a pane is resized.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resize event.</param>
        public SplitterEventBuilder Resize(string handler)
        {
            Handler("resize", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a pane is resized.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SplitterEventBuilder Resize(Func<object, object> handler)
        {
            Handler("resize", handler);

            return this;
        }

    }
}

