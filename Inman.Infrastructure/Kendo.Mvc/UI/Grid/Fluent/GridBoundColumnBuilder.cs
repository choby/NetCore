namespace Kendo.Mvc.UI.Fluent
{
	using System;
	using System.Net;
    using Microsoft.AspNetCore.Mvc.Rendering;


    /// <summary>
    /// Defines the fluent interface for configuring bound columns
    /// </summary>
    /// <typeparam name="T">The type of the data item</typeparam>
    public class GridBoundColumnBuilder<T> : GridColumnBuilderBase<IGridBoundColumn, GridBoundColumnBuilder<T>>
        where T : class
    {
        private ViewContext viewContext;
        private IUrlGenerator urlGenerator;
        /// <summary>
        /// Initializes a new instance of the <see cref="GridBoundColumnBuilder{T}"/> class.
        /// </summary>
        /// <param name="column">The column.</param>
        public GridBoundColumnBuilder(IGridBoundColumn column, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(column)
        {
            this.viewContext = viewContext;
            this.urlGenerator = urlGenerator;
        }

        /// <summary>
        /// Gets or sets the format for displaying the data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns => columns.Bound(o => o.OrderDate).Format("{0:dd/MM/yyyy}"))
        /// %&gt;
        /// </code>
        /// </example>        
        public GridBoundColumnBuilder<T> Format(string value)
        {
            // Doing the UrlDecode to allow {0} in ActionLink e.g. Html.ActionLink("Index", "Home", new { id = "{0}" })
            Column.Format = WebUtility.UrlDecode(value);

            return this;
        }

        /// <summary>
        /// Provides additional view data in the editor template for that column (if any).
        /// </summary>
        /// <remarks>
        /// The additional view data will be provided if the editing mode is set to in-line or in-cell. Otherwise
        /// use <see cref="GridEditingSettingsBuilder{T}.AdditionalViewData"/> 
        /// </remarks>
        /// <param name="additionalViewData">An anonymous object which contains the additional data</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns => {
        ///                 columns.Bound(o => o.Customer).EditorViewData(new { customers = Model.Customers });
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public GridBoundColumnBuilder<T> EditorViewData(object additionalViewData)
        {
            Column.AdditionalViewData = additionalViewData;

            return this;
        }       

        /// <summary>
        /// Specify which editor template should be used for the column
        /// </summary>
        /// <param name="templateName">name of the editor template</param>
        public GridBoundColumnBuilder<T> EditorTemplateName(string templateName)
        {
            Column.EditorTemplateName = templateName;
            return this;
        }
        /// <summary>
        /// Enables or disables sorting the column. All bound columns are sortable by default.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns => columns.Bound(o => o.OrderDate).Sortable(false))
        /// %&gt;
        /// </code>
        /// </example>        
        public GridBoundColumnBuilder<T> Sortable(bool value)
        {
            Column.Sortable = value;

            return this;
        }

        /// <summary>
        /// Enables or disables grouping by that column. All bound columns are groupable by default.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns => columns.Bound(o => o.OrderDate).Groupable(false))
        /// %&gt;
        /// </code>
        /// </example>        
        public GridBoundColumnBuilder<T> Groupable(bool value)
        {
            Column.Groupable = value;

            return this;
        }

        /// <summary>
        /// Enables or disables filtering the column. All bound columns are filterable by default.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns => columns.Bound(o => o.OrderDate).Filterable(false))
        /// %&gt;
        /// </code>
        /// </example>        
        public GridBoundColumnBuilder<T> Filterable(bool value)
        {
            Column.Filterable = value;

            return this;
        }

        public GridBoundColumnBuilder<T> Filterable(Action<GridBoundColumnFilterableBuilder> configurator)
        {
            configurator(new GridBoundColumnFilterableBuilder(Column.FilterableSettings, this.viewContext, this.urlGenerator));
            return this;
        }  
        
        /// <summary>
        /// Enables or disables HTML encoding the data of the column. All bound columns are encoded by default.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns => columns.Bound(o => o.OrderDate).Encoded(false))
        /// %&gt;
        /// </code>
        /// </example>        
        public GridBoundColumnBuilder<T> Encoded(bool value)
        {
            Column.Encoded = value;

            return this;
        }
		
        /// <summary>
        /// Sets the client template for the column.
        /// </summary>
        /// <param name="value">The template</param>
        /// <returns></returns>
        public GridBoundColumnBuilder<T> ClientTemplate(string value)
        {
            Column.ClientTemplate = value;

            return this;
        }

        /// <summary>
        /// Sets the client group template for the column.
        /// </summary>
        /// <param name="value">The template</param>
        /// <returns></returns>
        public GridBoundColumnBuilder<T> ClientGroupHeaderTemplate(string value)
        {
            Column.ClientGroupHeaderTemplate = value;

            return this;
        }


        /// <summary>
        /// Sets the editable function.
        /// </summary>
        /// <param name="editable">The editable function in a text tag.</param>
        public GridBoundColumnBuilder<T> Editable(Func<object, object> editable)
        {
            Column.Editable.TemplateDelegate = editable;

            return this;
        }

        /// <summary>
        /// Sets the editable function.
        /// </summary>
        /// <param name="editable">The name of the JavaScript function that will determine if the cell will be editable.</param>
        public GridBoundColumnBuilder<T> Editable(string editable)
        {
            Column.Editable.HandlerName = editable;

            return this;
        }

    }
}