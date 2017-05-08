using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeViewCheckboxesSettings class
    /// </summary>
    public partial class TreeViewCheckboxesSettings 
    {
        public bool? CheckChildren { get; set; }

        public string Name { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Enabled { get; set; }

        public TreeView TreeView { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (CheckChildren.HasValue)
            {
                settings["checkChildren"] = CheckChildren;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", TreeView.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            return settings;
        }
    }
}
