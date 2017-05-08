using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Slider for ASP.NET MVC events.
    /// </summary>
    public class SliderEventBuilder: EventBuilder
    {
        public SliderEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the slider value changes as a result of selecting a new value with the drag handle, buttons or keyboard.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public SliderEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the slider value changes as a result of selecting a new value with the drag handle, buttons or keyboard.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SliderEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the slide event.</param>
        public SliderEventBuilder Slide(string handler)
        {
            Handler("slide", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SliderEventBuilder Slide(Func<object, object> handler)
        {
            Handler("slide", handler);

            return this;
        }

    }
}

