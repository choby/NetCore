using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Menu for ASP.NET MVC events.
    /// </summary>
    public class MenuEventBuilder: EventBuilder
    {
        public MenuEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires before a sub menu gets closed. You can cancel this event to prevent closure.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the close event.</param>
        public MenuEventBuilder Close(string handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires before a sub menu gets closed. You can cancel this event to prevent closure.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MenuEventBuilder Close(Func<object, object> handler)
        {
            Handler("close", handler);

            return this;
        }

        /// <summary>
        /// Fires before a sub menu gets opened. You can cancel this event to prevent opening the sub menu.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the open event.</param>
        public MenuEventBuilder Open(string handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires before a sub menu gets opened. You can cancel this event to prevent opening the sub menu.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MenuEventBuilder Open(Func<object, object> handler)
        {
            Handler("open", handler);

            return this;
        }

        /// <summary>
        /// Fires when a sub menu gets opened and its animation finished.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the activate event.</param>
        public MenuEventBuilder Activate(string handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Fires when a sub menu gets opened and its animation finished.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MenuEventBuilder Activate(Func<object, object> handler)
        {
            Handler("activate", handler);

            return this;
        }

        /// <summary>
        /// Fires when a sub menu gets closed and its animation finished.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the deactivate event.</param>
        public MenuEventBuilder Deactivate(string handler)
        {
            Handler("deactivate", handler);

            return this;
        }

        /// <summary>
        /// Fires when a sub menu gets closed and its animation finished.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MenuEventBuilder Deactivate(Func<object, object> handler)
        {
            Handler("deactivate", handler);

            return this;
        }

        /// <summary>
        /// Fires when a menu item gets selected.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public MenuEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fires when a menu item gets selected.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public MenuEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

    }
}

