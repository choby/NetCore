using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Editor for ASP.NET MVC events.
    /// </summary>
    public class EditorEventBuilder: EventBuilder
    {
        public EditorEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when Editor is blurred and its content has changed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public EditorEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when Editor is blurred and its content has changed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder Change(Func<object, object> handler)
        {
            Handler("change", handler);

            return this;
        }

        /// <summary>
        /// Fires when an Editor command is executed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the execute event.</param>
        public EditorEventBuilder Execute(string handler)
        {
            Handler("execute", handler);

            return this;
        }

        /// <summary>
        /// Fires when an Editor command is executed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder Execute(Func<object, object> handler)
        {
            Handler("execute", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user depresses a keyboard key. Triggered multiple times if the user holds the key down.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the keydown event.</param>
        public EditorEventBuilder Keydown(string handler)
        {
            Handler("keydown", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user depresses a keyboard key. Triggered multiple times if the user holds the key down.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder Keydown(Func<object, object> handler)
        {
            Handler("keydown", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user releases a keyboard key.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the keyup event.</param>
        public EditorEventBuilder Keyup(string handler)
        {
            Handler("keyup", handler);

            return this;
        }

        /// <summary>
        /// Fires when the user releases a keyboard key.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder Keyup(Func<object, object> handler)
        {
            Handler("keyup", handler);

            return this;
        }

        /// <summary>
        /// Fires before the content is pasted in the Editor.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the paste event.</param>
        public EditorEventBuilder Paste(string handler)
        {
            Handler("paste", handler);

            return this;
        }

        /// <summary>
        /// Fires before the content is pasted in the Editor.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder Paste(Func<object, object> handler)
        {
            Handler("paste", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public EditorEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder PdfExport(Func<object, object> handler)
        {
            Handler("pdfExport", handler);

            return this;
        }

        /// <summary>
        /// Fires when the Editor selection has changed.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public EditorEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fires when the Editor selection has changed.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

    }
}

