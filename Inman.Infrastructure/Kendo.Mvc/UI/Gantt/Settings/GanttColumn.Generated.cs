using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttColumn class
    /// </summary>
    public partial class GanttColumn<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public string Field { get; set; }

        public string Title { get; set; }

        public string Format { get; set; }

        public string Width { get; set; }

        public bool? Editable { get; set; }

        public bool? Sortable { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            if (Width?.HasValue() == true)
            {
                settings["width"] = Width;
            }

            if (Editable.HasValue)
            {
                settings["editable"] = Editable;
            }

            if (Sortable.HasValue)
            {
                settings["sortable"] = Sortable;
            }

            return settings;
        }
    }
}
