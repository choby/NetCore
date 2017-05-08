using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class UploadValidationSettingsTagHelper
    {
        /// <summary>
        /// Lists which file extensions are allowed to be uploaded. Recognizes entries of both .type and type values.
        /// </summary>
        public String[] AllowedExtensions { get; set; }

        /// <summary>
        /// Defines the maximum file size that can be uploaded in bytes.
        /// </summary>
        public double? MaxFileSize { get; set; }

        /// <summary>
        /// Defines the minimum file size that can be uploaded in bytes.
        /// </summary>
        public double? MinFileSize { get; set; }

        internal Dictionary<string, object> Serialize()
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
