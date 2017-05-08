using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MultiSelect for ASP.NET MVC events.
    /// </summary>
    public class MultiSelectEventBuilder: EventBuilder
    {
        public MultiSelectEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when the value of the widget is changed by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public MultiSelectEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the widget is changed by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is closed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public MultiSelectEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is closed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public MultiSelectEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is about to filter the data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the filtering event.</param>
        public MultiSelectEventBuilder Filtering(string handler)
        {
            Handler("filtering", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is about to filter the data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder Filtering(Func<object, object> handler)
        {
            Handler("filtering", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is opened by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public MultiSelectEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is opened by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item from the popup is selected by the user.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public MultiSelectEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item from the popup is selected by the user.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item is deselected or tag is removed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the deselect event.</param>
        public MultiSelectEventBuilder Deselect(string handler)
        {
            Handler("deselect", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item is deselected or tag is removed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MultiSelectEventBuilder Deselect(Func<object, object> handler)
        {
            Handler("deselect", handler);

            return this;
        }

    }
}

