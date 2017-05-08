using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserTransportSettings class
    /// </summary>
    public partial class EditorImageBrowserTransportSettings 
    {
        public EditorImageBrowserTransportReadSettings Read { get; } = new EditorImageBrowserTransportReadSettings();

        public string ThumbnailUrl { get; set; }
        public ClientHandlerDescriptor ThumbnailUrlHandler { get; set; }

        public string UploadUrl { get; set; }

        public string ImageUrl { get; set; }
        public ClientHandlerDescriptor ImageUrlHandler { get; set; }

        public EditorImageBrowserTransportDestroySettings Destroy { get; } = new EditorImageBrowserTransportDestroySettings();

        public EditorImageBrowserTransportCreateSettings Create { get; } = new EditorImageBrowserTransportCreateSettings();


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var read = Read.Serialize();
            if (read.Any())
            {
                settings["read"] = read;
            }

            if (ThumbnailUrlHandler?.HasValue() == true)
            {
                settings["thumbnailUrl"] = ThumbnailUrlHandler;
            }
            else if (ThumbnailUrl?.HasValue() == true)
            {
               settings["thumbnailUrl"] = ThumbnailUrl;
            }


            if (UploadUrl?.HasValue() == true)
            {
                settings["uploadUrl"] = UploadUrl;
            }

            if (ImageUrlHandler?.HasValue() == true)
            {
                settings["imageUrl"] = ImageUrlHandler;
            }
            else if (ImageUrl?.HasValue() == true)
            {
               settings["imageUrl"] = ImageUrl;
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
