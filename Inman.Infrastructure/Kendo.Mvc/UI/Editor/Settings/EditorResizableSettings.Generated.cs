using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorResizableSettings class
    /// </summary>
    public partial class EditorResizableSettings 
    {
        public bool? Content { get; set; }

        public double? Min { get; set; }

        public double? Max { get; set; }

        public bool? Toolbar { get; set; }

        public bool? Enabled { get; set; }

        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Content.HasValue)
            {
                settings["content"] = Content;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            if (Toolbar.HasValue)
            {
                settings["toolbar"] = Toolbar;
            }

            return settings;
        }
    }
}
