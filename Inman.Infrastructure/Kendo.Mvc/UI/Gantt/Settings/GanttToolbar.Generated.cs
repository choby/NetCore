using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttToolbar class
    /// </summary>
    public partial class GanttToolbar<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public string Name { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public string Text { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Gantt.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            return settings;
        }
    }
}
