using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSchemaModelFieldsSettings class
    /// </summary>
    public partial class EditorFileBrowserSchemaModelFieldsSettings 
    {
        public EditorFileBrowserSchemaModelFieldsNameSettings Name { get; } = new EditorFileBrowserSchemaModelFieldsNameSettings();

        public EditorFileBrowserSchemaModelFieldsTypeSettings Type { get; } = new EditorFileBrowserSchemaModelFieldsTypeSettings();

        public EditorFileBrowserSchemaModelFieldsSizeSettings Size { get; } = new EditorFileBrowserSchemaModelFieldsSizeSettings();


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
