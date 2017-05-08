using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI AutoComplete for ASP.NET MVC events.
    /// </summary>
    public class AutoCompleteEventBuilder: EventBuilder
    {
        public AutoCompleteEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when the value of the widget is changed by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public AutoCompleteEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the widget is changed by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the suggestion popup of the widget is closed by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public AutoCompleteEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fired when the suggestion popup of the widget is closed by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public AutoCompleteEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is about to filter the data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the filtering event.</param>
        public AutoCompleteEventBuilder Filtering(string handler)
        {
            Handler("filtering", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is about to filter the data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteEventBuilder Filtering(Func<object, object> handler)
        {
            Handler("filtering", handler);

            return this;
        }

        /// <summary>
        /// Fired when the suggestion popup of the widget is opened by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public AutoCompleteEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fired when the suggestion popup of the widget is opened by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item from the suggestion popup is selected by the user.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public AutoCompleteEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item from the suggestion popup is selected by the user.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public AutoCompleteEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

    }
}

