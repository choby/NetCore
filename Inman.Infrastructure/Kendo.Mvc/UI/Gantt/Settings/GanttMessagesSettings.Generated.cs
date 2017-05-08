using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttMessagesSettings class
    /// </summary>
    public partial class GanttMessagesSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> Actions { get; } = new GanttMessagesActionsSettings<TTaskModel, TDependenciesModel>();

        public string Cancel { get; set; }

        public string DeleteDependencyConfirmation { get; set; }

        public string DeleteDependencyWindowTitle { get; set; }

        public string DeleteTaskConfirmation { get; set; }

        public string DeleteTaskWindowTitle { get; set; }

        public string Destroy { get; set; }

        public GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> Editor { get; } = new GanttMessagesEditorSettings<TTaskModel, TDependenciesModel>();

        public string Save { get; set; }

        public GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> Views { get; } = new GanttMessagesViewsSettings<TTaskModel, TDependenciesModel>();


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var actions = Actions.Serialize();
            if (actions.Any())
            {
                settings["actions"] = actions;
            }

            if (Cancel?.HasValue() == true)
            {
                settings["cancel"] = Cancel;
            }

            if (DeleteDependencyConfirmation?.HasValue() == true)
            {
                settings["deleteDependencyConfirmation"] = DeleteDependencyConfirmation;
            }

            if (DeleteDependencyWindowTitle?.HasValue() == true)
            {
                settings["deleteDependencyWindowTitle"] = DeleteDependencyWindowTitle;
            }

            if (DeleteTaskConfirmation?.HasValue() == true)
            {
                settings["deleteTaskConfirmation"] = DeleteTaskConfirmation;
            }

            if (DeleteTaskWindowTitle?.HasValue() == true)
            {
                settings["deleteTaskWindowTitle"] = DeleteTaskWindowTitle;
            }

            if (Destroy?.HasValue() == true)
            {
                settings["destroy"] = Destroy;
            }

            var editor = Editor.Serialize();
            if (editor.Any())
            {
                settings["editor"] = editor;
            }

            if (Save?.HasValue() == true)
            {
                settings["save"] = Save;
            }

            var views = Views.Serialize();
            if (views.Any())
            {
                settings["views"] = views;
            }

            return settings;
        }
    }
}
