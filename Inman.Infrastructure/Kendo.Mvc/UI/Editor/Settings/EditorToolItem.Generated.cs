using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorToolItem class
    /// </summary>
    public partial class EditorToolItem 
    {
        public string Text { get; set; }

        public string Value { get; set; }

        public string Context { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            if (Context?.HasValue() == true)
            {
                settings["context"] = Context;
            }

            return settings;
        }
    }
}
