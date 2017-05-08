using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ListView
    /// </summary>
    public partial class ListViewBuilder<T> : WidgetBuilderBase<ListView<T>, ListViewBuilder<T>> where T : class
    {
        public ListViewBuilder(ListView<T> component) : base(component)
        {
        }

        // Place custom settings here

        public ListViewBuilder<T> DataSource(Action<DataSourceBuilder<T>> configurator)
        {
            configurator(new DataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }
        public ListViewBuilder<T> BindTo(IEnumerable<T> dataSource)
        {
            Component.DataSource.Data = dataSource;

            return this;
        }

        public ListViewBuilder<T> DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;
            return this;
        }

        /// <summary>
        /// Binds the ListView to a list of objects
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView&lt;Order&gt;()
        ///             .Name("Orders")        
        ///             .BindTo((IEnumerable)ViewData["Orders"]);
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> BindTo(IEnumerable dataSource)
        {
            Component.DataSource.Data = dataSource;

            return this;
        }

        /// <summary>
        /// Specifies ListView item template.
        /// </summary>      
        /// <param name="templateId">The Id of the element which contains the template.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView&lt;Order&gt;()
        ///             .Name("Orders")        
        ///             .ClientTemplateId("listViewTemplate");
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> ClientTemplateId(string templateId)
        {
            Component.ClientTemplateId = templateId;

            return this;
        }
        /// <summary>
        /// Specifies ListView alt item template.
        /// </summary>      
        /// <param name="templateId">The Id of the element which contains the template.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView&lt;Order&gt;()
        ///             .Name("Orders")        
        ///             .ClientAltTemplateId("listViewTemplate");
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> ClientAltTemplateId(string templateId)
        {
            Component.ClientAltTemplateId = templateId;

            return this;
        }

        /// <summary>
        /// Allows paging of the data.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView()
        ///             .Name("ListView")
        ///             .Ajax(ajax => ajax.Action("Orders", "ListView"))        
        ///             .Pageable();
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> Pageable()
        {
            return Pageable(delegate { });
        }

        /// <summary>
        /// Allows paging of the data.
        /// </summary>
        /// <param name="pagerAction">Use builder to define paging settings.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView()
        ///             .Name("Grid")
        ///             .Ajax(ajax => ajax.Action("Orders", "ListView"))        
        ///             .Pageable(paging => paging.Enabled(true))
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> Pageable(Action<PageableBuilder> pagerAction)
        {
            Component.Pageable.Enabled = true;

            pagerAction(new PageableBuilder(Component.Pageable));

            return this;
        }

        public ListViewBuilder<T> Selectable(ListViewSelectionMode mode)
        {
            Container.Selectable.Enabled = true;
            Container.Selectable.Mode = mode;
            return this;
        }
        /// <summary>
        /// Enables single item selection.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView()
        ///             .Name("ListView")
        ///             .Selectable()
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> Selectable()
        {
            Component.Selectable.Enabled = true;
            if (!Component.Selectable.Mode.HasValue)
            {
                Component.Selectable.Mode = ListViewSelectionMode.Single;
            }
            return this;
        }

        /// <summary>
        /// Configures the ListView editing settings.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView()
        ///             .Name("ListView")
        ///             .Editable(settings => settings.Enabled(true))
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> Editable(Action<ListViewEditingSettingsBuilder<T>> configurator)
        {
            configurator(new ListViewEditingSettingsBuilder<T>(Component.Editable));

            return this;
        }

        /// <summary>
        /// Enables ListView editing.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView()
        ///             .Name("ListView")
        ///             .Editable()
        /// %&gt;
        /// </code>
        /// </example>
        public ListViewBuilder<T> Editable()
        {
            return Editable(settings => settings.Enabled(true));
        }
    }

}

