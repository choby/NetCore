using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttEditableSettings
    /// </summary>
    public partial class GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// If set to true the Gantt will display a confirmation dialog when the user deletes a task or a dependency.
        /// </summary>
        /// <param name="value">The value for Confirmation</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Confirmation(bool value)
        {
            Container.Confirmation = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to create tasks.
        /// </summary>
        /// <param name="value">The value for Create</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Create(bool value)
        {
            Container.Create = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to create dependencies.
        /// </summary>
        /// <param name="value">The value for DependencyCreate</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> DependencyCreate(bool value)
        {
            Container.DependencyCreate = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to delete dependencies.
        /// </summary>
        /// <param name="value">The value for DependencyDestroy</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> DependencyDestroy(bool value)
        {
            Container.DependencyDestroy = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to edit the percentComplete of the tasks.
        /// </summary>
        /// <param name="value">The value for DragPercentComplete</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> DragPercentComplete(bool value)
        {
            Container.DragPercentComplete = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to delete tasks.
        /// </summary>
        /// <param name="value">The value for Destroy</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Destroy(bool value)
        {
            Container.Destroy = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to move tasks.
        /// </summary>
        /// <param name="value">The value for Move</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Move(bool value)
        {
            Container.Move = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to reorder tasks in the task list.
        /// </summary>
        /// <param name="value">The value for Reorder</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Reorder(bool value)
        {
            Container.Reorder = value;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to resize tasks.
        /// </summary>
        /// <param name="value">The value for Resize</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Resize(bool value)
        {
            Container.Resize = value;
            return this;
        }

        /// <summary>
        /// The template which renders the editor.The template should contain elements whose name HTML attributes are set as the editable fields. This is how the Gantt will know
		/// which field to update. The other option is to use MVVM bindings in order to bind HTML elements to data item fields.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the editor.The template should contain elements whose name HTML attributes are set as the editable fields. This is how the Gantt will know
		/// which field to update. The other option is to use MVVM bindings in order to bind HTML elements to data item fields.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to false the user won't be able to update tasks.
        /// </summary>
        /// <param name="value">The value for Update</param>
        public GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel> Update(bool value)
        {
            Container.Update = value;
            return this;
        }

    }
}
