using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorTool class
    /// </summary>
    public partial class EditorTool 
    {
        public string Name { get; set; }

        public string Tooltip { get; set; }

        public ClientHandlerDescriptor Exec { get; set; }

        public List<EditorToolItem> Items { get; set; } = new List<EditorToolItem>();

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public ColorPickerPalette? Palette { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            if (Tooltip?.HasValue() == true)
            {
                settings["tooltip"] = Tooltip;
            }

            if (Exec?.HasValue() == true)
            {
                settings["exec"] = Exec;
            }

            var items = Items.Select(i => i.Serialize());
            if (items.Any())
            {
                settings["items"] = items;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Editor.IdPrefix, TemplateId
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
