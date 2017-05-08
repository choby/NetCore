using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DateTimePicker for ASP.NET MVC events.
    /// </summary>
    public class DateTimePickerEventBuilder: EventBuilder
    {
        public DateTimePickerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when the underlying value of a DateTimePicker is changed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public DateTimePickerEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the underlying value of a DateTimePicker is changed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DateTimePickerEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is closed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public DateTimePickerEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is closed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DateTimePickerEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is opened
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public DateTimePickerEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is opened
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DateTimePickerEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

    }
}

