using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Grid
    /// </summary>
    public partial class GridBuilder<T>: WidgetBuilderBase<Grid<T>, GridBuilder<T>>
        where T : class 
    {
        public GridBuilder(Grid<T> component) : base(component)
        {
        }

		/// <summary>
		/// If set to <c>true</c> the grid will perform custom binding.
		/// </summary>
		/// <param name="value">If true enables custom binding.</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .EnableCustomBinding(true)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>		
		/// </example>
		public GridBuilder<T> EnableCustomBinding(bool value)
		{
			Component.EnableCustomBinding = value;

			return this;
		}

		/// <summary>
		/// Binds the grid to a list of objects
		/// </summary>
		/// <param name="dataSource">The data source.</param>
		/// <example>	
		/// <code lang="Razor">
		/// @model IEnumerable&lt;Product&gt;
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .BindTo(Model)
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> BindTo(IEnumerable<T> dataSource)
		{
			Component.DataSource.Data = dataSource;

			return this;
		}

		/// <summary>
		/// Binds the grid to a list of objects
		/// </summary>
		/// <param name="dataSource">The data source.</param>
		/// <example>
		/// <code lang="Razor">
		/// @model IEnumerable;
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .BindTo(Model)
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> BindTo(IEnumerable dataSource)
		{
			Component.DataSource.Data = new CustomGroupingWrapper<T>(dataSource);
			return this;
		}

		/// <summary>
		/// Sets the editing configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the editing</param>
		/// <example>
		/// <code lang="Razor">
		///  @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name("Grid")
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///          .Ajax()
		///          .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///    .Editable(editing => editing.Mode(GridEditMode.PopUp))
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Editable(Action<GridEditingSettingsBuilder<T>> configurator)
		{
			configurator(new GridEditingSettingsBuilder<T>(Component.Editable));

			return this;
		}


		/// <summary>
		/// Enables grid editing.
		/// </summary>
		/// <example>
		/// <code lang="Razor">
		///  @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name("Grid")
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///          .Ajax()
		///          .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///    .Editable()
		/// )
		/// </code>	
		/// </example>
		public GridBuilder<T> Editable()
		{
			Component.Editable.Enabled = true;
			return this;
		}

		/// <summary>
		/// Sets the data source configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the data source</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>        
		/// </example>
		public GridBuilder<T> DataSource(Action<DataSourceBuilder<T>> configurator)
		{
			Component.DataSource.ServerAggregates = true;
			Component.DataSource.ServerFiltering = true;
			Component.DataSource.ServerGrouping = true;
			Component.DataSource.ServerPaging = true;
			Component.DataSource.ServerSorting = true;
			configurator(new DataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
			return this;
		}

        public GridBuilder<T> DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;
            return this;
        }


        /// <summary>
        /// Enables grid paging.
        /// </summary>
        /// <example>  
        ///<code lang="Razor">
        /// @(Html.Kendo().Grid&lt;Product&gt;()
        ///     .Name(&quot;grid&quot;)
        ///     .Pageable()
        ///     .DataSource(dataSource =&gt;
        ///         // configure the data source
        ///         dataSource
        ///             .Ajax()
        ///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
        ///     )
        /// )
        /// </code>
        /// </example>
        public GridBuilder<T> Pageable()
		{
			return Pageable(delegate { });
		}

		/// <summary>
		/// Sets the paging configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the paging</param>
		/// <example>
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Pageable(paging =>
		///         paging.Refresh(true)
		///     )
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Pageable(Action<PageableBuilder> configurator)
		{
			Component.Pageable.Enabled = true;

			configurator(new PageableBuilder(Component.Pageable));

			return this;
		}

		/// <summary>
		/// Enables grid filtering.
		/// </summary>
		/// <example>        
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Filterable()
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Filterable()
		{
			Component.Filterable.Enabled = true;
			return this;
		}

		/// <summary>
		/// Sets the filtering configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the filtering</param>
		/// <example>     
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Filterable(filtering =&gt; filtering.Enabled(true))
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Filterable(Action<GridFilterableSettingsBuilder> configurator)
		{
			Component.Filterable.Enabled = true;

			configurator(new GridFilterableSettingsBuilder(Component.Filterable));

			return this;
		}

		/// <summary>
		/// Sets the resizing configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the resizing</param>
		/// <example>
		/// <code lang="Razor">
		///  @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name("Grid")
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///          .Ajax()
		///          .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///    .Resizable(resizing => resizing.Columns(true))
		/// )
		/// </code>       
		/// </example>
		public GridBuilder<T> Resizable(Action<GridResizingSettingsBuilder> configurator)
		{

			configurator(new GridResizingSettingsBuilder(Component.Resizable));

			return this;
		}

		/// <summary>
		/// Sets the reordering configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the reordering</param>
		/// <example>
		/// <code lang="Razor">
		///  @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name("Grid")
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///          .Ajax()
		///          .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///    .Reorderable(reordering => reordering.Columns(true))
		/// )
		/// </code>       
		/// </example>
		public GridBuilder<T> Reorderable(Action<GridReorderingSettingsBuilder> configurator)
		{
			configurator(new GridReorderingSettingsBuilder(Component.Reorderable));

			return this;
		}

		/// <summary>
		/// Enables grid row selection.
		/// </summary>
		/// <example>	
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Selectable()
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Selectable()
		{
			Component.Selectable.Enabled = true;

			return this;
		}

		/// <summary>
		/// Sets the selection configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the selection</param>
		/// <example>
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Selectable(selection =&gt; selection.Enabled(true))
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Selectable(Action<GridSelectionSettingsBuilder> configurator)
		{
			Selectable();

			configurator(new GridSelectionSettingsBuilder(Component.Selectable));

			return this;
		}

		/// <summary>
		/// Enables grid scrolling.
		/// </summary>
		/// <example>		
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Scrollable()
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Scrollable()
		{
			Component.Scrollable.Enabled = true;

			return this;
		}

		/// <summary>
		/// Sets the scrolling configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the scrolling</param>
		/// <example>	
		///<code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Scrollable(scrolling =&gt; scrolling.Enabled(true))
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> Scrollable(Action<GridScrollSettingsBuilder> configurator)
		{
			Scrollable();

			configurator(new GridScrollSettingsBuilder(Component.Scrollable));

			return this;
		}

		/// <summary>
		/// Sets the column configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures columns</param>
		/// <example>
		/// <code lang="ASPX">
		/// &lt;%:Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .Columns(columns =&gt;
		///     {
		///         columns.Bound(product =&gt; product.ProductName).Title(&quot;Product Name&quot;);
		///         columns.Command(command =&gt; command.Destroy());
		///     })
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Destroy(destroy =&gt; destroy.Action(&quot;Products_Destroy&quot;, &quot;Home&quot;))
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		/// %&gt;
		/// </code>		
		/// </example>
		public GridBuilder<T> Columns(Action<GridColumnFactory<T>> configurator)
		{

			var factory = new GridColumnFactory<T>(Component, Component.ViewContext, Component.UrlGenerator);

			configurator(factory);

			return this;

		}
		/// <summary>
		/// Enables the adaptive rendering when viewed on mobile browser
		/// </summary>
		public GridBuilder<T> Mobile()
		{
			Component.Mobile = MobileMode.Auto;

			return this;
		}

		/// <summary>
		/// Used to determine if adaptive rendering should be used when viewed on mobile browser
		/// </summary>
		/// <remarks>
		/// Currently the Grid widget doesn't distinguish between phone and tablet option.
		/// </remarks>
		/// <param name="type"></param>
		public GridBuilder<T> Mobile(MobileMode type)
		{
			Component.Mobile = type;

			return this;
		}

		/// <summary>
		/// Sets the toolbar configuration of the grid.
		/// </summary>
		/// <param name="configurator">The lambda which configures the toolbar</param>
		/// <example>
		/// <code lang="Razor">
		///  @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name("Grid")
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///          .Ajax()
		///          .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///    .ToolBar(commands => commands.Create())
		/// )
		/// </code>		
		/// </example>
		public GridBuilder<T> ToolBar(Action<GridToolBarCommandFactory<T>> configurator)
		{
			configurator(new GridToolBarCommandFactory<T>(Component.ToolBar, Component));

			return this;
		}

		/// <summary>
		/// Sets the client-side row template of the grid. The client-side row template must contain a table row element (tr).
		/// </summary>
		/// <param name="template">The template</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///     .ClientRowTemplate(
		///     &quot;&lt;tr&gt;&quot; +
		///         &quot;&lt;td&gt;#: ProductName #&lt;/td&gt;&quot; +
		///         &quot;&lt;td&gt;#: UnitsInStock #&lt;/td&gt;&quot; +
		///     &quot;&lt;/tr&gt;&quot;
		///     )
		/// )
		/// </code>
		/// </example>
		public GridBuilder<T> ClientRowTemplate(string template)
		{
			Component.ClientRowTemplate = template;
			return this;
		}

		/// <summary>
		/// Sets the client-side alt row template of the grid. The client-side alt row template must contain a table row element (tr).
		/// </summary>
		/// <param name="template">The template</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///     .ClientAltRowTemplate(
		///     &quot;&lt;tr class='k-alt'&gt;&quot; +
		///         &quot;&lt;td&gt;#: ProductName #&lt;/td&gt;&quot; +
		///         &quot;&lt;td&gt;#: UnitsInStock #&lt;/td&gt;&quot; +
		///     &quot;&lt;/tr&gt;&quot;
		///     )
		/// )
		/// </code>		
		/// </example>
		public GridBuilder<T> ClientAltRowTemplate(string template)
		{
			Component.ClientAltRowTemplate = template;
			return this;
		}

		/// <summary>
		/// Sets the client-side row template of the grid. The client-side row template must contain a table row element (tr).
		/// </summary>
		/// <param name="template">The template</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///     .ClientRowTemplate(grid =&gt;
		///     &quot;&lt;tr&gt;&quot; +
		///         &quot;&lt;td&gt;#: ProductName #&lt;/td&gt;&quot; +
		///         &quot;&lt;td&gt;#: UnitsInStock #&lt;/td&gt;&quot; +
		///     &quot;&lt;/tr&gt;&quot;
		///     )
		/// )
		/// </code>		
		/// </example>
		public GridBuilder<T> ClientRowTemplate(Func<Grid<T>, string> template)
		{
			Component.ClientRowTemplate = template(Component);

			return this;
		}

		/// <summary>
		/// Sets the client-side alt row template of the grid. The client-side row template must contain a table row element (tr).
		/// </summary>
		/// <param name="template">The template</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///     .ClientAltRowTemplate(grid =&gt;
		///     &quot;&lt;tr&gt;&quot; +
		///         &quot;&lt;td&gt;#: ProductName #&lt;/td&gt;&quot; +
		///         &quot;&lt;td&gt;#: UnitsInStock #&lt;/td&gt;&quot; +
		///     &quot;&lt;/tr&gt;&quot;
		///     )
		/// )
		/// </code>		
		/// </example>
		public GridBuilder<T> ClientAltRowTemplate(Func<Grid<T>, string> template)
		{
			Component.ClientAltRowTemplate = template(Component);

			return this;
		}


		/// <summary>
		/// Sets the id of the script element which contains the client-side detail template of the grid.
		/// </summary>
		/// <param name="id">The id</param>
		/// <example>
		/// <code lang="Razor">
		/// @(Html.Kendo().Grid&lt;Product&gt;()
		///     .Name(&quot;grid&quot;)
		///     .DataSource(dataSource =&gt;
		///         // configure the data source
		///         dataSource
		///             .Ajax()
		///             .Read(read =&gt; read.Action(&quot;Products_Read&quot;, &quot;Home&quot;))
		///     )
		///     .ClientDetailTemplateId(&quot;detail-template&quot;)
		/// )
		/// &lt;script id=&quot;detail-template&quot; type=&quot;text/x-kendo-template&quot;&gt;
		///     Product Details:
		///     &lt;div&gt;Product Name: #: ProductName # &lt;/div&gt;
		///     &lt;div&gt;Units In Stock: #: UnitsInStock #&lt;/div&gt;
		/// &lt;/script&gt;
		/// </code>		
		/// </example>
		public GridBuilder<T> ClientDetailTemplateId(string id)
		{
			Component.ClientDetailTemplateId = id;

			return this;
		}
	}
}

