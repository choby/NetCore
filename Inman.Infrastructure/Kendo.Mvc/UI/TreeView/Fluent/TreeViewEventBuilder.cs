using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeView for ASP.NET MVC events.
    /// </summary>
    public class TreeViewEventBuilder: EventBuilder
    {
        public TreeViewEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Triggered when the selection has changed (either by the user or through the select method).
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public TreeViewEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the selection has changed (either by the user or through the select method).
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the user has checked or unchecked a checkbox.\n\t\t/// If checkChildren is true, the event is triggered after all checked states are updated.\n\t\t/// This event has been introduced in internal builds after 2014.2.828.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the check event.</param>
        public TreeViewEventBuilder Check(string handler)
        {
            Handler("check", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the user has checked or unchecked a checkbox.\n\t\t/// If checkChildren is true, the event is triggered after all checked states are updated.\n\t\t/// This event has been introduced in internal builds after 2014.2.828.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Check(Func<object, object> handler)
        {
            Handler("check", handler);

            return this;
        }

        /// <summary>
        /// Triggered before a subgroup gets collapsed. Cancellable.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapse event.</param>
        public TreeViewEventBuilder Collapse(string handler)
        {
            Handler("collapse", handler);

            return this;
        }

        /// <summary>
        /// Triggered before a subgroup gets collapsed. Cancellable.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Collapse(Func<object, object> handler)
        {
            Handler("collapse", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the dataSource change event has been processed (adding/removing items);
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public TreeViewEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Triggered after the dataSource change event has been processed (adding/removing items);
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Triggered while a node is being dragged.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drag event.</param>
        public TreeViewEventBuilder Drag(string handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Triggered while a node is being dragged.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Drag(Func<object, object> handler)
        {
            Handler("drag", handler);

            return this;
        }

        /// <summary>
        /// Triggered after a node has been dropped.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragend event.</param>
        public TreeViewEventBuilder DragEnd(string handler)
        {
            Handler("dragend", handler);

            return this;
        }

        /// <summary>
        /// Triggered after a node has been dropped.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder DragEnd(Func<object, object> handler)
        {
            Handler("dragend", handler);

            return this;
        }

        /// <summary>
        /// Triggered before the dragging of a node starts.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragstart event.</param>
        public TreeViewEventBuilder DragStart(string handler)
        {
            Handler("dragstart", handler);

            return this;
        }

        /// <summary>
        /// Triggered before the dragging of a node starts.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder DragStart(Func<object, object> handler)
        {
            Handler("dragstart", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a node is being dropped.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drop event.</param>
        public TreeViewEventBuilder Drop(string handler)
        {
            Handler("drop", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a node is being dropped.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Drop(Func<object, object> handler)
        {
            Handler("drop", handler);

            return this;
        }

        /// <summary>
        /// Triggered before a subgroup gets expanded.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expand event.</param>
        public TreeViewEventBuilder Expand(string handler)
        {
            Handler("expand", handler);

            return this;
        }

        /// <summary>
        /// Triggered before a subgroup gets expanded.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Expand(Func<object, object> handler)
        {
            Handler("expand", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the user moves the focus on another node
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the navigate event.</param>
        public TreeViewEventBuilder Navigate(string handler)
        {
            Handler("navigate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when the user moves the focus on another node
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Navigate(Func<object, object> handler)
        {
            Handler("navigate", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a node is being selected by the user. Cancellable.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public TreeViewEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a node is being selected by the user. Cancellable.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public TreeViewEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

    }
}

