using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesEditorSettings
    /// </summary>
    public partial class GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The text similar to "Assign" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for AssignButton</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> AssignButton(string value)
        {
            Container.AssignButton = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Task" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for EditorTitle</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> EditorTitle(string value)
        {
            Container.EditorTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "End" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for End</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> End(string value)
        {
            Container.End = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Complete" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for PercentComplete</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> PercentComplete(string value)
        {
            Container.PercentComplete = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Resources" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for Resources</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> Resources(string value)
        {
            Container.Resources = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Resources" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for ResourcesEditorTitle</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> ResourcesEditorTitle(string value)
        {
            Container.ResourcesEditorTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Resources" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for ResourcesHeader</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> ResourcesHeader(string value)
        {
            Container.ResourcesHeader = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Start" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for Start</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> Start(string value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Title" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Units" displayed in Gantt task editor.
        /// </summary>
        /// <param name="value">The value for UnitsHeader</param>
        public GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel> UnitsHeader(string value)
        {
            Container.UnitsHeader = value;
            return this;
        }

    }
}
