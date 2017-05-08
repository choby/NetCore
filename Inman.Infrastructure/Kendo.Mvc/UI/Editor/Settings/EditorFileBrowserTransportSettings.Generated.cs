using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserTransportSettings class
    /// </summary>
    public partial class EditorFileBrowserTransportSettings 
    {
        public EditorFileBrowserTransportReadSettings Read { get; } = new EditorFileBrowserTransportReadSettings();

        public string UploadUrl { get; set; }

        public string FileUrl { get; set; }
        public ClientHandlerDescriptor FileUrlHandler { get; set; }

        public EditorFileBrowserTransportDestroySettings Destroy { get; } = new EditorFileBrowserTransportDestroySettings();

        public EditorFileBrowserTransportCreateSettings Create { get; } = new EditorFileBrowserTransportCreateSettings();


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var read = Read.Serialize();
            if (read.Any())
            {
                settings["read"] = read;
            }

            if (UploadUrl?.HasValue() == true)
            {
                settings["uploadUrl"] = UploadUrl;
            }

            if (FileUrlHandler?.HasValue() == true)
            {
                settings["fileUrl"] = FileUrlHandler;
            }
            else if (FileUrl?.HasValue() == true)
            {
               settings["fileUrl"] = FileUrl;
            }


            var destroy = Destroy.Serialize();
            if (destroy.Any())
            {
                settings["destroy"] = destroy;
            }

            var create = Create.Serialize();
            if (create.Any())
            {
                settings["create"] = create;
            }

            return settings;
        }
    }
}
