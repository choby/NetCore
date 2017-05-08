using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Sortable for ASP.NET MVC events.
    /// </summary>
    public class SortableEventBuilder: EventBuilder
    {
        public SortableEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when sortable item drag starts.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the start event.</param>
        public SortableEventBuilder Start(string handler)
        {
            Handler("start", handler);

            return this;
        }

        /// <summary>
        /// Fires when sortable item drag starts.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SortableEventBuilder Start(Func<object, object> handler)
        {
            Handler("start", handler);

            return this;
        }

        /// <summary>
        /// Fires when Sortable's placeholder changes its position.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the move event.</param>
        public SortableEventBuilder Move(string handler)
        {
            Handler("move", handler);

            return this;
        }

        /// <summary>
        /// Fires when Sortable's placeholder changes its position.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SortableEventBuilder Move(Func<object, object> handler)
        {
            Handler("move", handler);

            return this;
        }

        /// <summary>
        /// Fires when item dragging ends but before the item's position is changed in the DOM. This event is suitable for preventing the sort action.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the end event.</param>
        public SortableEventBuilder End(string handler)
        {
            Handler("end", handler);

            return this;
        }

        /// <summary>
        /// Fires when item dragging ends but before the item's position is changed in the DOM. This event is suitable for preventing the sort action.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SortableEventBuilder End(Func<object, object> handler)
        {
            Handler("end", handler);

            return this;
        }

        /// <summary>
        /// Fires when item is sorted and the item's position is changed in the DOM.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public SortableEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when item is sorted and the item's position is changed in the DOM.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SortableEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when item sorting is canceled by pressing the Escape key.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cancel event.</param>
        public SortableEventBuilder Cancel(string handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Fires when item sorting is canceled by pressing the Escape key.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SortableEventBuilder Cancel(Func<object, object> handler)
        {
            Handler("cancel", handler);

            return this;
        }

    }
}

