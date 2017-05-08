using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListEditableSettings class
    /// </summary>
    public partial class TreeListEditableSettings<T> where T : class 
    {
        public bool? Move { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public string TemplateName { get; set; }

        public TreeListEditMode? Mode { get; set; }

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Move.HasValue)
            {
                settings["move"] = Move;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", TreeList.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Mode.HasValue)
            {
                settings["mode"] = Mode?.Serialize();
            }

            return settings;
        }
    }
}
