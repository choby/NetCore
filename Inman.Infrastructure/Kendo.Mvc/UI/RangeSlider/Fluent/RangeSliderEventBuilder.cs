using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI RangeSlider for ASP.NET MVC events.
    /// </summary>
    public class RangeSliderEventBuilder: EventBuilder
    {
        public RangeSliderEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the RangeSlider value changes as a result of selecting a new value with one of the drag handles or the keyboard.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public RangeSliderEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the RangeSlider value changes as a result of selecting a new value with one of the drag handles or the keyboard.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public RangeSliderEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the slide event.</param>
        public RangeSliderEventBuilder Slide(string handler)
        {
            Handler("slide", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public RangeSliderEventBuilder Slide(Func<object, object> handler)
        {
            Handler("slide", handler);

            return this;
        }

    }
}

