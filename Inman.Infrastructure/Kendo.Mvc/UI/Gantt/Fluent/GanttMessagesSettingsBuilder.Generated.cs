using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesSettings
    /// </summary>
    public partial class GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The configuration of the Gantt action messages. Use this option to customize or localize the Gantt action messages.
        /// </summary>
        /// <param name="configurator">The configurator for the actions setting.</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Actions(Action<GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
        {

            Container.Actions.Gantt = Container.Gantt;
            configurator(new GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>(Container.Actions));

            return this;
        }

        /// <summary>
        /// The text similar to "Cancel" displayed in Gantt.
        /// </summary>
        /// <param name="value">The value for Cancel</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Cancel(string value)
        {
            Container.Cancel = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Are you sure you want to delete this dependency?" displayed in Gantt dependency delete dialog.
        /// </summary>
        /// <param name="value">The value for DeleteDependencyConfirmation</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteDependencyConfirmation(string value)
        {
            Container.DeleteDependencyConfirmation = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete dependency" displayed in Gantt dependency delete dialog title.
        /// </summary>
        /// <param name="value">The value for DeleteDependencyWindowTitle</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteDependencyWindowTitle(string value)
        {
            Container.DeleteDependencyWindowTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Are you sure you want to delete this task?" displayed in Gantt task delete dialog.
        /// </summary>
        /// <param name="value">The value for DeleteTaskConfirmation</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteTaskConfirmation(string value)
        {
            Container.DeleteTaskConfirmation = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete task" displayed in Gantt task delete dialog title.
        /// </summary>
        /// <param name="value">The value for DeleteTaskWindowTitle</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> DeleteTaskWindowTitle(string value)
        {
            Container.DeleteTaskWindowTitle = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Delete" displayed in Gantt.
        /// </summary>
        /// <param name="value">The value for Destroy</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Destroy(string value)
        {
            Container.Destroy = value;
            return this;
        }

        /// <summary>
        /// The configuration of the Gantt editor messages. Use this option to customize or localize the Gantt editor messages.
        /// </summary>
        /// <param name="configurator">The configurator for the editor setting.</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Editor(Action<GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
        {

            Container.Editor.Gantt = Container.Gantt;
            configurator(new GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>(Container.Editor));

            return this;
        }

        /// <summary>
        /// The text similar to "Save" displayed in Gantt.
        /// </summary>
        /// <param name="value">The value for Save</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Save(string value)
        {
            Container.Save = value;
            return this;
        }

        /// <summary>
        /// The configuration of the Gantt view messages. Use this option to customize or localize the Gantt view messages.
        /// </summary>
        /// <param name="configurator">The configurator for the views setting.</param>
        public GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel> Views(Action<GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
        {

            Container.Views.Gantt = Container.Gantt;
            configurator(new GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>(Container.Views));

            return this;
        }

    }
}
