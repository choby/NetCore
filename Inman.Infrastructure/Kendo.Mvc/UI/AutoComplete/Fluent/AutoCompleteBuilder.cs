using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI AutoComplete
    /// </summary>
    public partial class AutoCompleteBuilder: WidgetBuilderBase<AutoComplete, AutoCompleteBuilder>
        
    {
        public AutoCompleteBuilder(AutoComplete component) : base(component)
        {
        }

        /// <summary>
        /// Binds the widget to an IEnumerable list.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .DataTextField("CompanyName")
        ///             .DataValueField("CompanyID")
        ///             .BindTo(new List<Company>
        ///             {
        ///                 new Company {
        ///                     CompanyName = "Text1",
        ///                     CompanyID = "Value1"
        ///                 },
        ///                 new Company {
        ///                     CompanyName = "Text2",
        ///                     CompanyID = "Value2"
        ///                 }
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public AutoCompleteBuilder BindTo(IEnumerable data)
        {
            Component.DataSource.Data = data;

            return this;
        }

                /// <summary>
        /// The filtering method used to determine the suggestions for the current value. The default filter is "startswith" -
		/// all data items which begin with the current widget value are displayed in the suggestion popup. The supported filter values are startswith, endswith and contains.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public AutoCompleteBuilder Filter(FilterType filterType)
        {
            Container.Filter = filterType.ToString();
            return this;
        }

        /// <summary>
        /// Sets the data source configuration of the AutoComplete.
        /// </summary>
        /// <param name="configurator">The lambda which configures the data source</param>
        public AutoCompleteBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
        {
            configurator(new ReadOnlyDataSourceBuilder(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }

        public AutoCompleteBuilder DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;

            return this;
        }
    }
}

