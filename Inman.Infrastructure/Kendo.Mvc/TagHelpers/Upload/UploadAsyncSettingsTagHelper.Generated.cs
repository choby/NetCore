using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class UploadAsyncSettingsTagHelper
    {
        /// <summary>
        /// The selected files will be uploaded immediately by default. You can change this behavior by setting autoUpload to false.
        /// </summary>
        public bool? AutoUpload { get; set; }

        /// <summary>
        /// The selected files will be uploaded in separate requests, if this is supported by the browser.
		/// You can change this behavior by setting batch to true, in which case all selected files will be uploaded in one request.The batch mode applies to multiple files, which are selected at the same time.
		/// Files selected one after the other will be uploaded in separate requests.
        /// </summary>
        public bool? Batch { get; set; }

        /// <summary>
        /// The name of the form field submitted to the Remove URL.
        /// </summary>
        public string RemoveField { get; set; }

        /// <summary>
        /// The URL of the handler responsible for removing uploaded files (if any). The handler must accept POST
		/// requests containing one or more "fileNames" fields specifying the files to be deleted.
        /// </summary>
        public string RemoveUrl { get; set; }

        /// <summary>
        /// The HTTP verb to be used by the remove action.
        /// </summary>
        public string RemoveVerb { get; set; }

        /// <summary>
        /// The name of the form field submitted to the save URL. The default value is the input name.
        /// </summary>
        public string SaveField { get; set; }

        /// <summary>
        /// The URL of the handler that will receive the submitted files. The handler must accept POST requests
		/// containing one or more fields with the same name as the original input name.
        /// </summary>
        public string SaveUrl { get; set; }

        /// <summary>
        /// Controls whether to send credentials (cookies, headers) for cross-site requests.
		/// This option will be ignored if the browser doesn't support File API.
        /// </summary>
        public bool? WithCredentials { get; set; }

        internal Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (AutoUpload.HasValue)
            {
                settings["autoUpload"] = AutoUpload;
            }

            if (Batch.HasValue)
            {
                settings["batch"] = Batch;
            }

            if (RemoveField?.HasValue() == true)
            {
                settings["removeField"] = RemoveField;
            }

            if (RemoveUrl?.HasValue() == true)
            {
                settings["removeUrl"] = RemoveUrl;
            }

            if (RemoveVerb?.HasValue() == true)
            {
                settings["removeVerb"] = RemoveVerb;
            }

            if (SaveField?.HasValue() == true)
            {
                settings["saveField"] = SaveField;
            }

            if (SaveUrl?.HasValue() == true)
            {
                settings["saveUrl"] = SaveUrl;
            }

            if (WithCredentials.HasValue)
            {
                settings["withCredentials"] = WithCredentials;
            }

            return settings;
        }
    }
}
