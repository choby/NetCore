using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserSchemaSettings class
    /// </summary>
    public partial class EditorImageBrowserSchemaSettings 
    {
        public EditorImageBrowserSchemaModelSettings Model { get; } = new EditorImageBrowserSchemaModelSettings();


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
