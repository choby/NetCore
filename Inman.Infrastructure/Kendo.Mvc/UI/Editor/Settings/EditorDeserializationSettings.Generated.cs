using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorDeserializationSettings class
    /// </summary>
    public partial class EditorDeserializationSettings 
    {
        public ClientHandlerDescriptor Custom { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Custom?.HasValue() == true)
            {
                settings["custom"] = Custom;
            }

            return settings;
        }
    }
}
