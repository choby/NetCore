using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class UploadFileTagHelper
    {
        /// <summary>
        /// The extension of the initial file.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// The name of the initial file.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The size of the initial file.
        /// </summary>
        public double? Size { get; set; }

        internal Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (Extension?.HasValue() == true)
            {
                settings["extension"] = Extension;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            return settings;
        }
    }
}
