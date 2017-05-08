using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MaskedTextBox for ASP.NET MVC events.
    /// </summary>
    public class MaskedTextBoxEventBuilder: EventBuilder
    {
        public MaskedTextBoxEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public MaskedTextBoxEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MaskedTextBoxEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

    }
}

