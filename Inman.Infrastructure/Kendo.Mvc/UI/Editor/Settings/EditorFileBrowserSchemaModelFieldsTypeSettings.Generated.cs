using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSchemaModelFieldsTypeSettings class
    /// </summary>
    public partial class EditorFileBrowserSchemaModelFieldsTypeSettings 
    {
        public ClientHandlerDescriptor Parse { get; set; }

        public string Field { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Parse?.HasValue() == true)
            {
                settings["parse"] = Parse;
            }

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
            }

            return settings;
        }
    }
}
