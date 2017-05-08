using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttEditableSettings class
    /// </summary>
    public partial class GanttEditableSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public bool? Confirmation { get; set; }

        public bool? Create { get; set; }

        public bool? DependencyCreate { get; set; }

        public bool? DependencyDestroy { get; set; }

        public bool? DragPercentComplete { get; set; }

        public bool? Destroy { get; set; }

        public bool? Move { get; set; }

        public bool? Reorder { get; set; }

        public bool? Resize { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? Update { get; set; }

        public bool? Enabled { get; set; }

        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Confirmation.HasValue)
            {
                settings["confirmation"] = Confirmation;
            }

            if (Create.HasValue)
            {
                settings["create"] = Create;
            }

            if (DependencyCreate.HasValue)
            {
                settings["dependencyCreate"] = DependencyCreate;
            }

            if (DependencyDestroy.HasValue)
            {
                settings["dependencyDestroy"] = DependencyDestroy;
            }

            if (DragPercentComplete.HasValue)
            {
                settings["dragPercentComplete"] = DragPercentComplete;
            }

            if (Destroy.HasValue)
            {
                settings["destroy"] = Destroy;
            }

            if (Move.HasValue)
            {
                settings["move"] = Move;
            }

            if (Reorder.HasValue)
            {
                settings["reorder"] = Reorder;
            }

            if (Resize.HasValue)
            {
                settings["resize"] = Resize;
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

            if (Update.HasValue)
            {
                settings["update"] = Update;
            }

            return settings;
        }
    }
}
