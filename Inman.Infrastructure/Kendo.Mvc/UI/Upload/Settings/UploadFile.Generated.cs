using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI UploadFile class
    /// </summary>
    public partial class UploadFile 
    {
        public string Extension { get; set; }

        public string Name { get; set; }

        public double? Size { get; set; }


        public Upload Upload { get; set; }

        protected Dictionary<string, object> SerializeSettings()
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
