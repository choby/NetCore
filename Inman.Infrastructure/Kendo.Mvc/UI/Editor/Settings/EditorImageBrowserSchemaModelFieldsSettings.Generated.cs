using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserSchemaModelFieldsSettings class
    /// </summary>
    public partial class EditorImageBrowserSchemaModelFieldsSettings 
    {
        public EditorImageBrowserSchemaModelFieldsNameSettings Name { get; } = new EditorImageBrowserSchemaModelFieldsNameSettings();

        public EditorImageBrowserSchemaModelFieldsTypeSettings Type { get; } = new EditorImageBrowserSchemaModelFieldsTypeSettings();

        public EditorImageBrowserSchemaModelFieldsSizeSettings Size { get; } = new EditorImageBrowserSchemaModelFieldsSizeSettings();


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var name = Name.Serialize();
            if (name.Any())
            {
                settings["name"] = name;
            }

            var type = Type.Serialize();
            if (type.Any())
            {
                settings["type"] = type;
            }

            var size = Size.Serialize();
            if (size.Any())
            {
                settings["size"] = size;
            }

            return settings;
        }
    }
}
