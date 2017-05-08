using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI NumericTextBox for ASP.NET MVC events.
    /// </summary>
    public class NumericTextBoxEventBuilder: EventBuilder
    {
        public NumericTextBoxEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public NumericTextBoxEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public NumericTextBoxEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the value is changed from the spin buttons
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the spin event.</param>
        public NumericTextBoxEventBuilder Spin(string handler)
        {
            Handler("spin", handler);

            return this;
        }

        /// <summary>
        /// Fires when the value is changed from the spin buttons
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public NumericTextBoxEventBuilder Spin(Func<object, object> handler)
        {
            Handler("spin", handler);

            return this;
        }

    }
}

