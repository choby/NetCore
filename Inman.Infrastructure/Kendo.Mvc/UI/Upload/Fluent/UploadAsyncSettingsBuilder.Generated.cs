using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring UploadAsyncSettings
    /// </summary>
    public partial class UploadAsyncSettingsBuilder
        
    {
        /// <summary>
        /// The selected files will be uploaded immediately by default. You can change this behavior by setting autoUpload to false.
        /// </summary>
        /// <param name="value">The value for AutoUpload</param>
        public UploadAsyncSettingsBuilder AutoUpload(bool value)
        {
            Container.AutoUpload = value;
            return this;
        }

        /// <summary>
        /// The selected files will be uploaded in separate requests, if this is supported by the browser.
		/// You can change this behavior by setting batch to true, in which case all selected files will be uploaded in one request.The batch mode applies to multiple files, which are selected at the same time.
		/// Files selected one after the other will be uploaded in separate requests.
        /// </summary>
        /// <param name="value">The value for Batch</param>
        public UploadAsyncSettingsBuilder Batch(bool value)
        {
            Container.Batch = value;
            return this;
        }

        /// <summary>
        /// The selected files will be uploaded in separate requests, if this is supported by the browser.
		/// You can change this behavior by setting batch to true, in which case all selected files will be uploaded in one request.The batch mode applies to multiple files, which are selected at the same time.
		/// Files selected one after the other will be uploaded in separate requests.
        /// </summary>
        public UploadAsyncSettingsBuilder Batch()
        {
            Container.Batch = true;
            return this;
        }

        /// <summary>
        /// The name of the form field submitted to the Remove URL.
        /// </summary>
        /// <param name="value">The value for RemoveField</param>
        public UploadAsyncSettingsBuilder RemoveField(string value)
        {
            Container.RemoveField = value;
            return this;
        }

        /// <summary>
        /// The URL of the handler responsible for removing uploaded files (if any). The handler must accept POST
		/// requests containing one or more "fileNames" fields specifying the files to be deleted.
        /// </summary>
        /// <param name="value">The value for RemoveUrl</param>
        public UploadAsyncSettingsBuilder RemoveUrl(string value)
        {
            Container.RemoveUrl = value;
            return this;
        }

        /// <summary>
        /// The HTTP verb to be used by the remove action.
        /// </summary>
        /// <param name="value">The value for RemoveVerb</param>
        public UploadAsyncSettingsBuilder RemoveVerb(string value)
        {
            Container.RemoveVerb = value;
            return this;
        }

        /// <summary>
        /// The name of the form field submitted to the save URL. The default value is the input name.
        /// </summary>
        /// <param name="value">The value for SaveField</param>
        public UploadAsyncSettingsBuilder SaveField(string value)
        {
            Container.SaveField = value;
            return this;
        }

        /// <summary>
        /// The URL of the handler that will receive the submitted files. The handler must accept POST requests
		/// containing one or more fields with the same name as the original input name.
        /// </summary>
        /// <param name="value">The value for SaveUrl</param>
        public UploadAsyncSettingsBuilder SaveUrl(string value)
        {
            Container.SaveUrl = value;
            return this;
        }

        /// <summary>
        /// Controls whether to send credentials (cookies, headers) for cross-site requests.
		/// This option will be ignored if the browser doesn't support File API.
        /// </summary>
        /// <param name="value">The value for WithCredentials</param>
        public UploadAsyncSettingsBuilder WithCredentials(bool value)
        {
            Container.WithCredentials = value;
            return this;
        }

    }
}
