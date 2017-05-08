using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Calendar for ASP.NET MVC events.
    /// </summary>
    public class CalendarEventBuilder: EventBuilder
    {
        public CalendarEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the selected date is changed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public CalendarEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the selected date is changed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public CalendarEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when calendar navigates.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the navigate event.</param>
        public CalendarEventBuilder Navigate(string handler)
        {
            Handler("navigate", handler);

            return this;
        }

        /// <summary>
        /// Fires when calendar navigates.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public CalendarEventBuilder Navigate(Func<object, object> handler)
        {
            Handler("navigate", handler);

            return this;
        }

    }
}

