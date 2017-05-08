using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSchemaModelSettings class
    /// </summary>
    public partial class EditorFileBrowserSchemaModelSettings 
    {
        public string Id { get; set; }

        public EditorFileBrowserSchemaModelFieldsSettings Fields { get; } = new EditorFileBrowserSchemaModelFieldsSettings();


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Id?.HasValue() == true)
            {
                settings["id"] = Id;
            }

            var fields = Fields.Serialize();
            if (fields.Any())
            {
                settings["fields"] = fields;
            }

            return settings;
        }
    }
}
