using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Upload component
    /// </summary>
    public partial class Upload 
    {
        public UploadAsyncSettings Async { get; } = new UploadAsyncSettings();

        public string DropZone { get; set; }

        public List<UploadFile> Files { get; set; } = new List<UploadFile>();

        public bool? Multiple { get; set; }

        public bool? ShowFileList { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public UploadValidationSettings Validation { get; } = new UploadValidationSettings();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var async = Async.Serialize();
            if (async.Any())
            {
                settings["async"] = async;
            }

            if (DropZone?.HasValue() == true)
            {
                settings["dropZone"] = DropZone;
            }

            var files = Files.Select(i => i.Serialize());
            if (files.Any())
            {
                settings["files"] = files;
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

            var validation = Validation.Serialize();
            if (validation.Any())
            {
                settings["validation"] = validation;
            }

            return settings;
        }
    }
}
