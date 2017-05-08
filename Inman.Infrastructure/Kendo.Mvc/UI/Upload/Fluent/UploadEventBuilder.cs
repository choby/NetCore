using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Upload for ASP.NET MVC events.
    /// </summary>
    public class UploadEventBuilder: EventBuilder
    {
        public UploadEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        /// <summary>
        /// Fires when the upload has been cancelled while in progress.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cancel event.</param>
        public UploadEventBuilder Cancel(string handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Fires when the upload has been cancelled while in progress.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Cancel(Func<object, object> handler)
        {
            Handler("cancel", handler);

            return this;
        }

        /// <summary>
        /// Triggered when files are cleared by clicking on the "Clear" button. Note: Cancelling this event will prevent the clearing the selected files.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the clear event.</param>
        public UploadEventBuilder Clear(string handler)
        {
            Handler("clear", handler);

            return this;
        }

        /// <summary>
        /// Triggered when files are cleared by clicking on the "Clear" button. Note: Cancelling this event will prevent the clearing the selected files.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Clear(Func<object, object> handler)
        {
            Handler("clear", handler);

            return this;
        }

        /// <summary>
        /// Fires when all active uploads have completed either successfully or with errors.Note: The complete event fires only when the upload is in\n\t\t/// async mode.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the complete event.</param>
        public UploadEventBuilder Complete(string handler)
        {
            Handler("complete", handler);

            return this;
        }

        /// <summary>
        /// Fires when all active uploads have completed either successfully or with errors.Note: The complete event fires only when the upload is in\n\t\t/// async mode.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Complete(Func<object, object> handler)
        {
            Handler("complete", handler);

            return this;
        }

        /// <summary>
        /// Fires when an upload / remove operation has failed.Note: The error event fires only when the upload is in\n\t\t/// async mode.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public UploadEventBuilder Error(string handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Fires when an upload / remove operation has failed.Note: The error event fires only when the upload is in\n\t\t/// async mode.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Error(Func<object, object> handler)
        {
            Handler("error", handler);

            return this;
        }

        /// <summary>
        /// Fires when upload progress data is available.Note: The progress event fires only when the upload is in\n\t\t/// async mode.Note: The progress event is not fired in IE.\n\t\t/// See Supported Browsers
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the progress event.</param>
        public UploadEventBuilder Progress(string handler)
        {
            Handler("progress", handler);

            return this;
        }

        /// <summary>
        /// Fires when upload progress data is available.Note: The progress event fires only when the upload is in\n\t\t/// async mode.Note: The progress event is not fired in IE.\n\t\t/// See Supported Browsers
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Progress(Func<object, object> handler)
        {
            Handler("progress", handler);

            return this;
        }

        /// <summary>
        /// Fires when an uploaded file is about to be removed.\n\t\t/// Cancelling the event will prevent the remove.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the remove event.</param>
        public UploadEventBuilder Remove(string handler)
        {
            Handler("remove", handler);

            return this;
        }

        /// <summary>
        /// Fires when an uploaded file is about to be removed.\n\t\t/// Cancelling the event will prevent the remove.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Remove(Func<object, object> handler)
        {
            Handler("remove", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a file(s) is selected. Note: Cancelling this event will prevent the selection from\n\t\t/// occurring.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public UploadEventBuilder Select(string handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Triggered when a file(s) is selected. Note: Cancelling this event will prevent the selection from\n\t\t/// occurring.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Select(Func<object, object> handler)
        {
            Handler("select", handler);

            return this;
        }

        /// <summary>
        /// Fires when an upload / remove operation has been completed successfully.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the success event.</param>
        public UploadEventBuilder Success(string handler)
        {
            Handler("success", handler);

            return this;
        }

        /// <summary>
        /// Fires when an upload / remove operation has been completed successfully.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Success(Func<object, object> handler)
        {
            Handler("success", handler);

            return this;
        }

        /// <summary>
        /// Fires when one or more files are about to be uploaded.\n\t\t/// Canceling the event will prevent the upload.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the upload event.</param>
        public UploadEventBuilder Upload(string handler)
        {
            Handler("upload", handler);

            return this;
        }

        /// <summary>
        /// Fires when one or more files are about to be uploaded.\n\t\t/// Canceling the event will prevent the upload.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public UploadEventBuilder Upload(Func<object, object> handler)
        {
            Handler("upload", handler);

            return this;
        }

    }
}

