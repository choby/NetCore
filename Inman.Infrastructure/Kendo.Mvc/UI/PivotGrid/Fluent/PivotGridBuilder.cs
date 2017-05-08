using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PivotGrid
    /// </summary>
    public partial class PivotGridBuilder<T>: WidgetBuilderBase<PivotGrid<T>, PivotGridBuilder<T>>
        where T : class 
    {
        public PivotGridBuilder(PivotGrid<T> component) : base(component)
        {
        }

        /// <summary>
        /// Use it to set the Id of the PivotConfigurator.
        /// </summary>
        /// <param name="configurator">The configurator</param>
        public PivotGridBuilder<T> Configurator(string configurator)
        {
            Component.Configurator = configurator;

            return this;
        }

        /// <summary>
        /// Sets the data source configuration of the grid.
        /// </summary>
        /// <param name="configurator">The lambda which configures the data source</param>
        public PivotGridBuilder<T> DataSource(Action<PivotDataSourceBuilder<T>> configurator)
        {
            configurator(new PivotDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }

        public PivotGridBuilder<T> DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;
            return this;
        }

        /// <summary>
        /// Binds the pivotGrid to a list of objects
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        public PivotGridBuilder<T> BindTo(IEnumerable<T> dataSource)
        {
            Component.DataSource.Data = dataSource;

            return this;
        }

        /// <summary>
        /// Sets the messages of the pivotGrid.
        /// </summary>
        /// <param name="addViewAction">The lambda which configures the pivotGrid messages</param>
        public PivotGridBuilder<T> Messages(Action<PivotGridMessagesBuilder> addViewAction)
        {
            PivotGridMessagesBuilder builder = new PivotGridMessagesBuilder(Component.Messages);

            addViewAction(builder);

            return this;
        }

        /// <summary>
        /// Sets the KPI Status template of the pivot grid.
        /// </summary>
        /// <param name="template">The template</param>
        /// <example>
        /// <code lang="Razor">
        /// @(Html.Kendo().PivotGrid()
        ///       .Name(&quot;pivotgrid&quot;)
        ///       .KPIStatusTemplate(&quot;<em>#: dataItem.value #</em>&quot;)
        ///       .DataSource(dataSource =&gt;
        ///         dataSource.Xmla()
        ///            .Columns(columns =&gt; columns.Add(&quot;[Date].[Calendar]&quot;).Expand(true))
        ///            .Rows(rows =&gt; rows.Add(&quot;[Geography].[City]&quot;))
        ///            .Measures(measures =&gt; measures.Values(new string[]{&quot;[Measures].[Internet Sales Amount]&quot;}))
        ///            .Transport(transport =&gt; transport
        ///                .Connection(connection =&gt; connection
        ///                    .Catalog(&quot;Adventure Works DW 2008R2&quot;)
        ///                    .Cube(&quot;Adventure Works&quot;))
        ///                .Read(read =&gt; read
        ///                    .Url(&quot;http://demos.telerik.com/olap/msmdpump.dll&quot;)
        ///                    .DataType(&quot;text&quot;)
        ///                    .ContentType(&quot;text/xml&quot;)
        ///                    .Type(HttpVerbs.Post)
        ///                )
        ///            )
        ///        )
        ///    )
        /// </code>
        /// </example>
        public PivotGridBuilder<T> KPIStatusTemplate(string template)
        {
            Component.KPIStatusTemplate = template;

            return this;
        }

        /// <summary>
        /// Sets the KPI Status template of the pivot grid.
        /// </summary>
        /// <param name="templateId">The template id</param>
        /// <example>
        /// <code lang="Razor">
        /// @(Html.Kendo().PivotGrid()
        ///       .Name(&quot;pivotgrid&quot;)
        ///       .KPIStatusTemplateId(&quot;kpiStatusTemplateId&quot;)
        ///       .DataSource(dataSource =&gt;
        ///         dataSource.Xmla()
        ///            .Columns(columns =&gt; columns.Add(&quot;[Date].[Calendar]&quot;).Expand(true))
        ///            .Rows(rows =&gt; rows.Add(&quot;[Geography].[City]&quot;))
        ///            .Measures(measures =&gt; measures.Values(new string[]{&quot;[Measures].[Internet Sales Amount]&quot;}))
        ///            .Transport(transport =&gt; transport
        ///                .Connection(connection =&gt; connection
        ///                    .Catalog(&quot;Adventure Works DW 2008R2&quot;)
        ///                    .Cube(&quot;Adventure Works&quot;))
        ///                .Read(read =&gt; read
        ///                    .Url(&quot;http://demos.telerik.com/olap/msmdpump.dll&quot;)
        ///                    .DataType(&quot;text&quot;)
        ///                    .ContentType(&quot;text/xml&quot;)
        ///                    .Type(HttpVerbs.Post)
        ///                )
        ///            )
        ///        )
        ///    )
        /// </code>
        /// </example>
        public PivotGridBuilder<T> KPIStatusTemplateId(string templateId)
        {
            Component.KPIStatusTemplateId = templateId;

            return this;
        }
        //......
        /// <summary>
        /// Sets the KPI Trend template of the pivot grid.
        /// </summary>
        /// <param name="template">The template</param>
        /// <example>
        /// <code lang="Razor">
        /// @(Html.Kendo().PivotGrid()
        ///       .Name(&quot;pivotgrid&quot;)
        ///       .KPITrendTemplate(&quot;<em>#: dataItem.value #</em>&quot;)
        ///       .DataSource(dataSource =&gt;
        ///         dataSource.Xmla()
        ///            .Columns(columns =&gt; columns.Add(&quot;[Date].[Calendar]&quot;).Expand(true))
        ///            .Rows(rows =&gt; rows.Add(&quot;[Geography].[City]&quot;))
        ///            .Measures(measures =&gt; measures.Values(new string[]{&quot;[Measures].[Internet Sales Amount]&quot;}))
        ///            .Transport(transport =&gt; transport
        ///                .Connection(connection =&gt; connection
        ///                    .Catalog(&quot;Adventure Works DW 2008R2&quot;)
        ///                    .Cube(&quot;Adventure Works&quot;))
        ///                .Read(read =&gt; read
        ///                    .Url(&quot;http://demos.telerik.com/olap/msmdpump.dll&quot;)
        ///                    .DataType(&quot;text&quot;)
        ///                    .ContentType(&quot;text/xml&quot;)
        ///                    .Type(HttpVerbs.Post)
        ///                )
        ///            )
        ///        )
        ///    )
        /// </code>
        /// </example>
        public PivotGridBuilder<T> KPITrendTemplate(string template)
        {
            Component.KPITrendTemplate = template;

            return this;
        }

        /// <summary>
        /// Sets the KPI Trend template of the pivot grid.
        /// </summary>
        /// <param name="templateId">The template id</param>
        /// <example>
        /// <code lang="Razor">
        /// @(Html.Kendo().PivotGrid()
        ///       .Name(&quot;pivotgrid&quot;)
        ///       .KPITrendTemplateId(&quot;kpiTrendTemplateId&quot;)
        ///       .DataSource(dataSource =&gt;
        ///         dataSource.Xmla()
        ///            .Columns(columns =&gt; columns.Add(&quot;[Date].[Calendar]&quot;).Expand(true))
        ///            .Rows(rows =&gt; rows.Add(&quot;[Geography].[City]&quot;))
        ///            .Measures(measures =&gt; measures.Values(new string[]{&quot;[Measures].[Internet Sales Amount]&quot;}))
        ///            .Transport(transport =&gt; transport
        ///                .Connection(connection =&gt; connection
        ///                    .Catalog(&quot;Adventure Works DW 2008R2&quot;)
        ///                    .Cube(&quot;Adventure Works&quot;))
        ///                .Read(read =&gt; read
        ///                    .Url(&quot;http://demos.telerik.com/olap/msmdpump.dll&quot;)
        ///                    .DataType(&quot;text&quot;)
        ///                    .ContentType(&quot;text/xml&quot;)
        ///                    .Type(HttpVerbs.Post)
        ///                )
        ///            )
        ///        )
        ///    )
        /// </code>
        /// </example>
        public PivotGridBuilder<T> KPITrendTemplateId(string templateId)
        {
            Component.KPITrendTemplateId = templateId;

            return this;
        }

    }
}

