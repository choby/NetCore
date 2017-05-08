using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PanelBar for ASP.NET MVC events.
    /// </summary>
    public class PanelBarEventBuilder: EventBuilder
    {
        public PanelBarEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is activated.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the activate event.</param>
        public PanelBarEventBuilder Activate(string handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is activated.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder Activate(Func<object, object> handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is collapsed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapse event.</param>
        public PanelBarEventBuilder Collapse(string handler)
        {
            Handler("collapse", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is collapsed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder Collapse(Func<object, object> handler)
        {
            Handler("collapse", handler);

            return this;
        }

        /// <summary>
        /// Fires when content is fetched from an AJAX request.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the contentLoad event.</param>
        public PanelBarEventBuilder ContentLoad(string handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Fires when content is fetched from an AJAX request.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder ContentLoad(Func<object, object> handler)
        {
            Handler("contentLoad", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the dataSource change event has been processed (adding/removing items);
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public PanelBarEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the dataSource change event has been processed (adding/removing items);
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fires when AJAX request results in an error.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public PanelBarEventBuilder Error(string handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Fires when AJAX request results in an error.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder Error(Func<object, object> handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is expanded.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expand event.</param>
        public PanelBarEventBuilder Expand(string handler)
        {
            Handler("expand", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is expanded.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder Expand(Func<object, object> handler)
        {
            Handler("expand", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is selected.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public PanelBarEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered when an item of a PanelBar is selected.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public PanelBarEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

    }
}

