using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DatePicker for ASP.NET MVC events.
    /// </summary>
    public class DatePickerEventBuilder: EventBuilder
    {
        public DatePickerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public DatePickerEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DatePickerEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar is closed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public DatePickerEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar is closed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DatePickerEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar is opened
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public DatePickerEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires when the calendar is opened
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public DatePickerEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

    }
}

