using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSchemaModelFieldsNameSettings class
    /// </summary>
    public partial class EditorFileBrowserSchemaModelFieldsNameSettings 
    {
        public string Field { get; set; }

        public ClientHandlerDescriptor Parse { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
            }

            if (Parse?.HasValue() == true)
            {
                settings["parse"] = Parse;
            }

            return settings;
        }
    }
}
