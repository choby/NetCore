using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttColumn
    /// </summary>
    public partial class GanttColumnBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The field to which the column is bound. The value of this field is displayed by the column during data binding.
		/// The field name should be a valid Javascript identifier and should contain no spaces, no special characters, and the first character should be a letter.
        /// </summary>
        /// <param name="value">The value for Field</param>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Field(string value)
        {
            Container.Field = value;
            return this;
        }

        /// <summary>
        /// The text that is displayed in the column header cell. If not set the field is used.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// The width of the column. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Width(string value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// Specifies whether this column can be edited by the user.
        /// </summary>
        /// <param name="value">The value for Editable</param>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Editable(bool value)
        {
            Container.Editable = value;
            return this;
        }

        /// <summary>
        /// Specifies whether this column can be edited by the user.
        /// </summary>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Editable()
        {
            Container.Editable = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort this column by clicking its header cells. By default sorting is disabled.
        /// </summary>
        /// <param name="value">The value for Sortable</param>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Sortable(bool value)
        {
            Container.Sortable = value;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort this column by clicking its header cells. By default sorting is disabled.
        /// </summary>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Sortable()
        {
            Container.Sortable = true;
            return this;
        }

    }
}
