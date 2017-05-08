using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Scheduler for ASP.NET MVC events.
    /// </summary>
    public class SchedulerEventBuilder: EventBuilder
    {
        public SchedulerEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fired when a new event is about to be added.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the add event.</param>
        public SchedulerEventBuilder Add(string handler)
        {
            Handler("add", handler);

            return this;
        }

        /// <summary>
        /// Fired when a new event is about to be added.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Add(Func<object, object> handler)
        {
            Handler("add", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user cancels editing by clicking the "cancel" button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cancel event.</param>
        public SchedulerEventBuilder Cancel(string handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user cancels editing by clicking the "cancel" button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Cancel(Func<object, object> handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user selects a cell or event in the scheduler.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public SchedulerEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user selects a cell or event in the scheduler.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBinding event.</param>
        public SchedulerEventBuilder DataBinding(string handler)
        {
            Handler("dataBinding", handler);

            return this;
        }

        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder DataBinding(Func<object, object> handler)
        {
            Handler("dataBinding", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public SchedulerEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder DataBound(Func<object, object> handler)
        {
            Handler("dataBound", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user opens a scheduler event in edit mode by or creates a new event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the edit event.</param>
        public SchedulerEventBuilder Edit(string handler)
        {
            Handler("edit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user opens a scheduler event in edit mode by or creates a new event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Edit(Func<object, object> handler)
        {
            Handler("edit", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts to drag an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the moveStart event.</param>
        public SchedulerEventBuilder MoveStart(string handler)
        {
            Handler("moveStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts to drag an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder MoveStart(Func<object, object> handler)
        {
            Handler("moveStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is moving an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the move event.</param>
        public SchedulerEventBuilder Move(string handler)
        {
            Handler("move", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is moving an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Move(Func<object, object> handler)
        {
            Handler("move", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user stops moving an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the moveEnd event.</param>
        public SchedulerEventBuilder MoveEnd(string handler)
        {
            Handler("moveEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user stops moving an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder MoveEnd(Func<object, object> handler)
        {
            Handler("moveEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user changes the selected date, or view of the schedulerThe event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the navigate event.</param>
        public SchedulerEventBuilder Navigate(string handler)
        {
            Handler("navigate", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user changes the selected date, or view of the schedulerThe event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Navigate(Func<object, object> handler)
        {
            Handler("navigate", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public SchedulerEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder PdfExport(Func<object, object> handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user performs "destroy" action.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the remove event.</param>
        public SchedulerEventBuilder Remove(string handler)
        {
            Handler("remove", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user performs "destroy" action.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Remove(Func<object, object> handler)
        {
            Handler("remove", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts to resize an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resizeStart event.</param>
        public SchedulerEventBuilder ResizeStart(string handler)
        {
            Handler("resizeStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user starts to resize an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder ResizeStart(Func<object, object> handler)
        {
            Handler("resizeStart", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is resizing an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resize event.</param>
        public SchedulerEventBuilder Resize(string handler)
        {
            Handler("resize", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user is resizing an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Resize(Func<object, object> handler)
        {
            Handler("resize", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user releases the mouse after resizing an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the resizeEnd event.</param>
        public SchedulerEventBuilder ResizeEnd(string handler)
        {
            Handler("resizeEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user releases the mouse after resizing an event.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder ResizeEnd(Func<object, object> handler)
        {
            Handler("resizeEnd", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user saves a scheduler event by clicking the "save" button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the save event.</param>
        public SchedulerEventBuilder Save(string handler)
        {
            Handler("save", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user saves a scheduler event by clicking the "save" button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public SchedulerEventBuilder Save(Func<object, object> handler)
        {
            Handler("save", handler);

            return this;
        }

    }
}

