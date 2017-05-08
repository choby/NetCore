using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListEditableSettings
    /// </summary>
    public partial class TreeListEditableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Enables drag&amp;drop UI of rows between parents.
        /// </summary>
        /// <param name="value">The value for Move</param>
        public TreeListEditableSettingsBuilder<T> Move(bool value)
        {
            Container.Move = value;
            return this;
        }

        /// <summary>
        /// Enables drag&amp;drop UI of rows between parents.
        /// </summary>
        public TreeListEditableSettingsBuilder<T> Move()
        {
            Container.Move = true;
            return this;
        }

        /// <summary>
        /// The template which renders the popup editor.The template should contain elements whose name HTML attributes are set as the editable fields. This is how the treelist will know
		/// which field to update. The other option is to use MVVM bindings in order to bind HTML elements to data item fields.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public TreeListEditableSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the popup editor.The template should contain elements whose name HTML attributes are set as the editable fields. This is how the treelist will know
		/// which field to update. The other option is to use MVVM bindings in order to bind HTML elements to data item fields.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public TreeListEditableSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The EditorTemplate which to be rendered as editor.
        /// </summary>
        /// <param name="value">The value for TemplateName</param>
        public TreeListEditableSettingsBuilder<T> TemplateName(string value)
        {
            Container.TemplateName = value;
            return this;
        }

        /// <summary>
        /// Represents the editing modes supported by Kendo UI TreeList for ASP.NET MVC
        /// </summary>
        /// <param name="value">The value for Mode</param>
        public TreeListEditableSettingsBuilder<T> Mode(TreeListEditMode value)
        {
            Container.Mode = value;
            return this;
        }

    }
}
