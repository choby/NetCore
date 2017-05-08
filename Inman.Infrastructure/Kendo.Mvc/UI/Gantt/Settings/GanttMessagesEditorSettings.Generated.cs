using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttMessagesEditorSettings class
    /// </summary>
    public partial class GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public string AssignButton { get; set; }

        public string EditorTitle { get; set; }

        public string End { get; set; }

        public string PercentComplete { get; set; }

        public string Resources { get; set; }

        public string ResourcesEditorTitle { get; set; }

        public string ResourcesHeader { get; set; }

        public string Start { get; set; }

        public string Title { get; set; }

        public string UnitsHeader { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AssignButton?.HasValue() == true)
            {
                settings["assignButton"] = AssignButton;
            }

            if (EditorTitle?.HasValue() == true)
            {
                settings["editorTitle"] = EditorTitle;
            }

            if (End?.HasValue() == true)
            {
                settings["end"] = End;
            }

            if (PercentComplete?.HasValue() == true)
            {
                settings["percentComplete"] = PercentComplete;
            }

            if (Resources?.HasValue() == true)
            {
                settings["resources"] = Resources;
            }

            if (ResourcesEditorTitle?.HasValue() == true)
            {
                settings["resourcesEditorTitle"] = ResourcesEditorTitle;
            }

            if (ResourcesHeader?.HasValue() == true)
            {
                settings["resourcesHeader"] = ResourcesHeader;
            }

            if (Start?.HasValue() == true)
            {
                settings["start"] = Start;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            if (UnitsHeader?.HasValue() == true)
            {
                settings["unitsHeader"] = UnitsHeader;
            }

            return settings;
        }
    }
}
