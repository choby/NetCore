using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Notification for ASP.NET MVC events.
    /// </summary>
    public class NotificationEventBuilder: EventBuilder
    {
        public NotificationEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when a notification's hiding animation starts.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the hide event.</param>
        public NotificationEventBuilder Hide(string handler)
        {
            Handler("hide", handler);

            return this;
        }

        /// <summary>
        /// Fires when a notification's hiding animation starts.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public NotificationEventBuilder Hide(Func<object, object> handler)
        {
            Handler("hide", handler);

            return this;
        }

        /// <summary>
        /// Fires when a notification's showing animation starts.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the show event.</param>
        public NotificationEventBuilder Show(string handler)
        {
            Handler("show", handler);

            return this;
        }

        /// <summary>
        /// Fires when a notification's showing animation starts.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public NotificationEventBuilder Show(Func<object, object> handler)
        {
            Handler("show", handler);

            return this;
        }

    }
}

