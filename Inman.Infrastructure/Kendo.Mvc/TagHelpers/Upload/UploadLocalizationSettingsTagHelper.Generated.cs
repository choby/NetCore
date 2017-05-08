using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class UploadLocalizationSettingsTagHelper
    {
        /// <summary>
        /// Sets the text of the cancel button text.
        /// </summary>
        public string Cancel { get; set; }

        /// <summary>
        /// Sets the text of the clear button.
        /// </summary>
        public string ClearSelectedFiles { get; set; }

        /// <summary>
        /// Sets the drop zone hint.
        /// </summary>
        public string DropFilesHere { get; set; }

        /// <summary>
        /// Sets the header status message for uploaded files.
        /// </summary>
        public string HeaderStatusUploaded { get; set; }

        /// <summary>
        /// Sets the header status message for files that are being uploaded.
        /// </summary>
        public string HeaderStatusUploading { get; set; }

        /// <summary>
        /// Sets the text for invalid file extension validation message.
        /// </summary>
        public string InvalidFileExtension { get; set; }

        /// <summary>
        /// Sets the text for an invalid maxFileSize validation message.
        /// </summary>
        public string InvalidMaxFileSize { get; set; }

        /// <summary>
        /// Sets the text for an invalid minFileSize validation message.
        /// </summary>
        public string InvalidMinFileSize { get; set; }

        /// <summary>
        /// Sets the text of the remove button text.
        /// </summary>
        public string Remove { get; set; }

        /// <summary>
        /// Sets the text of the retry button text.
        /// </summary>
        public string Retry { get; set; }

        /// <summary>
        /// Sets the "Select..." button text.
        /// </summary>
        public string Select { get; set; }

        /// <summary>
        /// Sets the status message for failed uploads.
        /// </summary>
        public string StatusFailed { get; set; }

        /// <summary>
        /// Sets the status message for uploaded files.
        /// </summary>
        public string StatusUploaded { get; set; }

        /// <summary>
        /// Sets the status message for files that are being uploaded.
        /// </summary>
        public string StatusUploading { get; set; }

        /// <summary>
        /// Sets the text of the "Upload files" button.
        /// </summary>
        public string UploadSelectedFiles { get; set; }

        internal Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (Cancel?.HasValue() == true)
            {
                settings["cancel"] = Cancel;
            }

            if (ClearSelectedFiles?.HasValue() == true)
            {
                settings["clearSelectedFiles"] = ClearSelectedFiles;
            }

            if (DropFilesHere?.HasValue() == true)
            {
                settings["dropFilesHere"] = DropFilesHere;
            }

            if (HeaderStatusUploaded?.HasValue() == true)
            {
                settings["headerStatusUploaded"] = HeaderStatusUploaded;
            }

            if (HeaderStatusUploading?.HasValue() == true)
            {
                settings["headerStatusUploading"] = HeaderStatusUploading;
            }

            if (InvalidFileExtension?.HasValue() == true)
            {
                settings["invalidFileExtension"] = InvalidFileExtension;
            }

            if (InvalidMaxFileSize?.HasValue() == true)
            {
                settings["invalidMaxFileSize"] = InvalidMaxFileSize;
            }

            if (InvalidMinFileSize?.HasValue() == true)
            {
                settings["invalidMinFileSize"] = InvalidMinFileSize;
            }

            if (Remove?.HasValue() == true)
            {
                settings["remove"] = Remove;
            }

            if (Retry?.HasValue() == true)
            {
                settings["retry"] = Retry;
            }

            if (Select?.HasValue() == true)
            {
                settings["select"] = Select;
            }

            if (StatusFailed?.HasValue() == true)
            {
                settings["statusFailed"] = StatusFailed;
            }

            if (StatusUploaded?.HasValue() == true)
            {
                settings["statusUploaded"] = StatusUploaded;
            }

            if (StatusUploading?.HasValue() == true)
            {
                settings["statusUploading"] = StatusUploading;
            }

            if (UploadSelectedFiles?.HasValue() == true)
            {
                settings["uploadSelectedFiles"] = UploadSelectedFiles;
            }

            return settings;
        }
    }
}
