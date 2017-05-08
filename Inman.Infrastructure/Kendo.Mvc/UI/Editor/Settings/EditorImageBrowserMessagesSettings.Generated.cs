using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserMessagesSettings class
    /// </summary>
    public partial class EditorImageBrowserMessagesSettings 
    {
        public string UploadFile { get; set; }

        public string OrderBy { get; set; }

        public string OrderByName { get; set; }

        public string OrderBySize { get; set; }

        public string DirectoryNotFound { get; set; }

        public string EmptyFolder { get; set; }

        public string DeleteFile { get; set; }

        public string InvalidFileType { get; set; }

        public string OverwriteFile { get; set; }

        public string Search { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (UploadFile?.HasValue() == true)
            {
                settings["uploadFile"] = UploadFile;
            }

            if (OrderBy?.HasValue() == true)
            {
                settings["orderBy"] = OrderBy;
            }

            if (OrderByName?.HasValue() == true)
            {
                settings["orderByName"] = OrderByName;
            }

            if (OrderBySize?.HasValue() == true)
            {
                settings["orderBySize"] = OrderBySize;
            }

            if (DirectoryNotFound?.HasValue() == true)
            {
                settings["directoryNotFound"] = DirectoryNotFound;
            }

            if (EmptyFolder?.HasValue() == true)
            {
                settings["emptyFolder"] = EmptyFolder;
            }

            if (DeleteFile?.HasValue() == true)
            {
                settings["deleteFile"] = DeleteFile;
            }

            if (InvalidFileType?.HasValue() == true)
            {
                settings["invalidFileType"] = InvalidFileType;
            }

            if (OverwriteFile?.HasValue() == true)
            {
                settings["overwriteFile"] = OverwriteFile;
            }

            if (Search?.HasValue() == true)
            {
                settings["search"] = Search;
            }

            return settings;
        }
    }
}
