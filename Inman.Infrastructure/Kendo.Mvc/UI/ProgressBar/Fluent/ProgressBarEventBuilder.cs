using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ProgressBar for ASP.NET MVC events.
    /// </summary>
    public class ProgressBarEventBuilder: EventBuilder
    {
        public ProgressBarEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when the value of the ProgressBar has changed. If the progress animation is enabled, the event will be fired after the animation has completed (does not applies to chunk ProgressBar).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public ProgressBarEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the ProgressBar has changed. If the progress animation is enabled, the event will be fired after the animation has completed (does not applies to chunk ProgressBar).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ProgressBarEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the ProgressBar reaches the maximum value.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the complete event.</param>
        public ProgressBarEventBuilder Complete(string handler)
        {
            Handler("complete", handler);

            return this;
        }

        /// <summary>
        /// Fired when the value of the ProgressBar reaches the maximum value.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ProgressBarEventBuilder Complete(Func<object, object> handler)
        {
            Handler("complete", handler);

            return this;
        }

    }
}

