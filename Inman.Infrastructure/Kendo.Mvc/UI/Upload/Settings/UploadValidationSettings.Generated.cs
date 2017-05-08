using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI UploadValidationSettings class
    /// </summary>
    public partial class UploadValidationSettings 
    {
        public String[] AllowedExtensions { get; set; }

        public double? MaxFileSize { get; set; }

        public double? MinFileSize { get; set; }


        public Upload Upload { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllowedExtensions?.Any() == true)
            {
                settings["allowedExtensions"] = AllowedExtensions;
            }

            if (MaxFileSize.HasValue)
            {
                settings["maxFileSize"] = MaxFileSize;
            }

            if (MinFileSize.HasValue)
            {
                settings["minFileSize"] = MinFileSize;
            }

            return settings;
        }
    }
}
