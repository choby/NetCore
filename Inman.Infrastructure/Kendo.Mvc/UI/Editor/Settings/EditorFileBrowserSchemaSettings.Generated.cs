using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSchemaSettings class
    /// </summary>
    public partial class EditorFileBrowserSchemaSettings 
    {
        public EditorFileBrowserSchemaModelSettings Model { get; } = new EditorFileBrowserSchemaModelSettings();


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var model = Model.Serialize();
            if (model.Any())
            {
                settings["model"] = model;
            }

            return settings;
        }
    }
}
