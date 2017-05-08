using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TimePicker for ASP.NET MVC events.
    /// </summary>
    public class TimePickerEventBuilder: EventBuilder
    {
        public TimePickerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public TimePickerEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TimePickerEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the time drop-down list is closed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public TimePickerEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the time drop-down list is closed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TimePickerEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires when the time drop-down list is opened
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public TimePickerEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires when the time drop-down list is opened
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TimePickerEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

    }
}

