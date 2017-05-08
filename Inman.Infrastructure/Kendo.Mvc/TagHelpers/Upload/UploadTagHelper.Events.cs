using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    public partial class UploadTagHelper
    {
        /// <summary>
        /// Fires when the upload has been cancelled while in progress.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cancel event.</param>
        public string OnCancel { get; set; }

        /// <summary>
        /// Triggered when files are cleared by clicking on the "Clear" button. Note: Cancelling this event will prevent the clearing the selected files.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the clear event.</param>
        public string OnClear { get; set; }

        /// <summary>
        /// Fires when all active uploads have completed either successfully or with errors.Note: The complete event fires only when the upload is in\n\t\t/// async mode.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the complete event.</param>
        public string OnComplete { get; set; }

        /// <summary>
        /// Fires when an upload / remove operation has failed.Note: The error event fires only when the upload is in\n\t\t/// async mode.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the error event.</param>
        public string OnError { get; set; }

        /// <summary>
        /// Fires when upload progress data is available.Note: The progress event fires only when the upload is in\n\t\t/// async mode.Note: The progress event is not fired in IE.\n\t\t/// See Supported Browsers
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the progress event.</param>
        public string OnProgress { get; set; }

        /// <summary>
        /// Fires when an uploaded file is about to be removed.\n\t\t/// Cancelling the event will prevent the remove.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the remove event.</param>
        public string OnRemove { get; set; }

        /// <summary>
        /// Triggered when a file(s) is selected. Note: Cancelling this event will prevent the selection from\n\t\t/// occurring.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the select event.</param>
        public string OnSelect { get; set; }

        /// <summary>
        /// Fires when an upload / remove operation has been completed successfully.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the success event.</param>
        public string OnSuccess { get; set; }

        /// <summary>
        /// Fires when one or more files are about to be uploaded.\n\t\t/// Canceling the event will prevent the upload.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the upload event.</param>
        public string OnUpload { get; set; }


        protected override Dictionary<string, object> SerializeEvents()
        {
            var settings = new Dictionary<string, object>();

            if (OnCancel?.HasValue() == true)
            {
                settings["cancel"] = CreateHandler(OnCancel);
            }

            if (OnClear?.HasValue() == true)
            {
                settings["clear"] = CreateHandler(OnClear);
            }

            if (OnComplete?.HasValue() == true)
            {
                settings["complete"] = CreateHandler(OnComplete);
            }

            if (OnError?.HasValue() == true)
            {
                settings["error"] = CreateHandler(OnError);
            }

            if (OnProgress?.HasValue() == true)
            {
                settings["progress"] = CreateHandler(OnProgress);
            }

            if (OnRemove?.HasValue() == true)
            {
                settings["remove"] = CreateHandler(OnRemove);
            }

            if (OnSelect?.HasValue() == true)
            {
                settings["select"] = CreateHandler(OnSelect);
            }

            if (OnSuccess?.HasValue() == true)
            {
                settings["success"] = CreateHandler(OnSuccess);
            }

            if (OnUpload?.HasValue() == true)
            {
                settings["upload"] = CreateHandler(OnUpload);
            }

            return settings;
        }
    }
}

