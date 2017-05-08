using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Button for ASP.NET MVC events.
    /// </summary>
    public class ButtonEventBuilder: EventBuilder
    {
        public ButtonEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the Button is clicked with the mouse, touched on a touch device, or ENTER (or SPACE) is pressed while the Button is focused.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the click event.</param>
        public ButtonEventBuilder Click(string handler)
        {
            Handler("click", handler);

            return this;
        }

        /// <summary>
        /// Fires when the Button is clicked with the mouse, touched on a touch device, or ENTER (or SPACE) is pressed while the Button is focused.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ButtonEventBuilder Click(Func<object, object> handler)
        {
            Handler("click", handler);

            return this;
        }

    }
}

