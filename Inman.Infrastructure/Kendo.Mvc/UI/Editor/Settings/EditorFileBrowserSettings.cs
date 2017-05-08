using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSettings class
    /// </summary>
    public partial class EditorFileBrowserSettings
    {
        public const string DefaultFileTypes = "*.*";

        public EditorFileBrowserSettings()
        {
            FileTypes = DefaultFileTypes;

            Create = new EditorFileBrowserOperation();
            Destroy = new EditorFileBrowserOperation();
            File = new EditorFileBrowserOperation();
            Read = new EditorFileBrowserOperation();
            Upload = new EditorFileBrowserOperation();
        }

        public EditorFileBrowserOperation Create { get; set; }

        public EditorFileBrowserOperation File { get; set; }

        public EditorFileBrowserOperation Destroy { get; set; }

        public EditorFileBrowserOperation Read { get; set; }

        public EditorFileBrowserOperation Upload { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            var read = Read.Serialize();
            if (read.Any())
            {
                var transport = new Dictionary<string, object>();
                settings["transport"] = transport;

                transport["read"] = read;
                transport["type"] = "filebrowser-aspnetmvc";

                var create = Create.Serialize();
                if (create.Any())
                {
                    transport["create"] = create;
                }

                var destroy = Destroy.Serialize();
                if (destroy.Any())
                {
                    transport["destroy"] = destroy;
                }

                var file = File.Url;
                if (file.HasValue())
                {
                    file = Regex.Replace(file, "(%20)*%7B0(%20)*", "{0", RegexOptions.IgnoreCase);
                    file = Regex.Replace(file, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
                    transport["fileUrl"] = file;
                }

                var upload = Upload.Serialize();
                if (upload.Any())
                {
                    transport["uploadUrl"] = upload["url"];
                }
            }

            return settings;
        }
    }
}
