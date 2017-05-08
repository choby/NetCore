using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI FlatColorPicker for ASP.NET MVC events.
    /// </summary>
    public class FlatColorPickerEventBuilder: EventBuilder
    {
        public FlatColorPickerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggers when a new color has been selected.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public FlatColorPickerEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Triggers when a new color has been selected.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public FlatColorPickerEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

    }
}

