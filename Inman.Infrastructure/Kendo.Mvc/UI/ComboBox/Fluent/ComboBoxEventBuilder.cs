using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ComboBox for ASP.NET MVC events.
    /// </summary>
    public class ComboBoxEventBuilder: EventBuilder
    {
        public ComboBoxEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when the value of the widget is changed by the user. As of 2015 Q3 SP1 cascading widget will trigger change event when its value is changed due to parent update.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public ComboBoxEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the widget is changed by the user. As of 2015 Q3 SP1 cascading widget will trigger change event when its value is changed due to parent update.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is closed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public ComboBoxEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is closed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public ComboBoxEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is about to filter the data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the filtering event.</param>
        public ComboBoxEventBuilder Filtering(string handler)
        {
            Handler("filtering", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is about to filter the data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder Filtering(Func<object, object> handler)
        {
            Handler("filtering", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is opened by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public ComboBoxEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fired when the popup of the widget is opened by the user.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item from the popup is selected by the user either with mouse/tap or with keyboard navigation.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public ComboBoxEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when an item from the popup is selected by the user either with mouse/tap or with keyboard navigation.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the widget is changed via API or user interaction.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cascade event.</param>
        public ComboBoxEventBuilder Cascade(string handler)
        {
            Handler("cascade", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the widget is changed via API or user interaction.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ComboBoxEventBuilder Cascade(Func<object, object> handler)
        {
            Handler("cascade", handler);

            return this;
        }

    }
}

