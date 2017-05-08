using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttToolbar
    /// </summary>
    public partial class GanttToolbarBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The name of the toolbar command. Either a built-in ("append" and "pdf") or custom. The name is reflected in one of the CSS classes, which is applied to the button - k-gantt-name.
		/// This class can be used to obtain reference to the button after Gantt initialization and attach click handlers.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public GanttToolbarBuilder<TTaskModel, TDependenciesModel> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The template which renders the command. By default renders a button.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public GanttToolbarBuilder<TTaskModel, TDependenciesModel> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the command. By default renders a button.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public GanttToolbarBuilder<TTaskModel, TDependenciesModel> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The text displayed by the command button. If not set the name` option would be used as the button text instead.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public GanttToolbarBuilder<TTaskModel, TDependenciesModel> Text(string value)
        {
            Container.Text = value;
            return this;
        }

    }
}
