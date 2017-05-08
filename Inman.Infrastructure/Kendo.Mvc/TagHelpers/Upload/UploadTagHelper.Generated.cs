using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class UploadTagHelper
    {
        public UploadAsyncSettingsTagHelper Async { get; set; }
        /// <summary>
        /// Initializes a dropzone element(s) based on a given selector that provides drag and drop file upload.
        /// </summary>
        public string DropZone { get; set; }

        /// <summary>
        /// Enables (true) or disables (false) an Upload. A disabled
		/// Upload may be re-enabled via enable().
        /// </summary>
        public bool? Enabled { get; set; }

        public UploadFilesTagHelper Files { get; set; }

        public UploadLocalizationSettingsTagHelper Localization { get; set; }
        /// <summary>
        /// Enables (true) or disables (false) the ability to select multiple files.
		/// If false, users will be able to select only one file at a time. Note: This option does not
		/// limit the total number of uploaded files in an asynchronous configuration.
        /// </summary>
        public bool? Multiple { get; set; }

        /// <summary>
        /// Enables (true) or disables (false) the ability to display a file listing
		/// for uploading a file(s). Disabling a file listing may be useful you wish to customize the UI; use the
		/// client-side events to build your own UI.
        /// </summary>
        public bool? ShowFileList { get; set; }

        /// <summary>
        /// The template used to render the files in the list
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// The template used to render the files in the list
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public string TemplateId { get; set; }

        public UploadValidationSettingsTagHelper Validation { get; set; }
        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Async != null)
            {
                var async = Async.Serialize();

                if (async.Any())
                {
                    settings["async"] = async;
                }
            }

            if (DropZone?.HasValue() == true)
            {
                settings["dropZone"] = DropZone;
            }

            if (Enabled.HasValue)
            {
                settings["enabled"] = Enabled;
            }

            if (Files != null)
            {
                var files = Files.Select(i => i.Serialize());

                if (files.Any())
                {
                    settings["files"] = files;
                }
            }

            if (Localization != null)
            {
                var localization = Localization.Serialize();

                if (localization.Any())
                {
                    settings["localization"] = localization;
                }
            }

            if (Multiple.HasValue)
            {
                settings["multiple"] = Multiple;
            }

            if (ShowFileList.HasValue)
            {
                settings["showFileList"] = ShowFileList;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Validation != null)
            {
                var validation = Validation.Serialize();

                if (validation.Any())
                {
                    settings["validation"] = validation;
                }
            }

            return settings;
        }
    }
}
