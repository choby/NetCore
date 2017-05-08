namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PanelBar
    /// </summary>
    public partial class PanelBarBuilder: WidgetBuilderBase<PanelBar, PanelBarBuilder>
        
    {
        public PanelBarBuilder(PanelBar component) : base(component)
        {
        }

        /// <summary>
        /// Defines the items in the panelbar
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder Items(Action<PanelBarItemFactory> addAction)
        {
            var factory = new PanelBarItemFactory(Component, Component.ViewContext);

            addAction(factory);

            return this;
        }

        /// <summary>
        /// Configure the DataSource of the component
        /// </summary>
        /// <param name="configurator">The action that configures the <see cref="DataSource"/>.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///     .Name("PanelBar")
        ///     .DataSource(dataSource => dataSource
        ///         .Read(read => read
        ///             .Action("Employees", "PanelBar")
        ///         )
        ///     )
        ///  %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder DataSource(Action<HierarchicalDataSourceBuilder<object>> configurator)
        {
            configurator(new HierarchicalDataSourceBuilder<object>(Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));

            return this;
        }
        /// <summary>
        /// Set ID of the DataSource that to be used for data binding
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <returns></returns>
        public PanelBarBuilder DataSource(string dataSourceId)
        {
            this.Component.DataSourceId = dataSourceId;

            return this;
        }

        /// <summary>
        /// Binds the PanelBar to a list of items.
        /// Use if a hierarchy of items is being sent from the controller; to bind the PanelBar declaratively, use the Items() method.
        /// </summary>
        /// <param name="items">The list of items</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .BindTo(model)
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder BindTo(IEnumerable<PanelBarItemModel> items)
        {
            Component.BindTo(items, mapping => mapping
                .For<PanelBarItemModel>(binding => binding
                    .ItemDataBound((item, node) =>
                    {
                        item.Text = node.Text;
                        item.Enabled = node.Enabled;
                        item.Expanded = node.Expanded;
                        item.Encoded = node.Encoded;
                        item.Id = node.Id;
                        item.Selected = node.Selected;
                        item.SpriteCssClasses = node.SpriteCssClass;

                        item.Url = node.Url;
                        item.ImageUrl = node.ImageUrl;
                        foreach (var key in node.ImageHtmlAttributes.Keys)
                        {
                            item.ImageHtmlAttributes[key] = node.ImageHtmlAttributes[key];
                        }
                        foreach (var key in node.HtmlAttributes.Keys)
                        {
                            item.HtmlAttributes[key] = node.HtmlAttributes[key];
                        }
                        foreach (var key in node.LinkHtmlAttributes.Keys)
                        {
                            item.LinkHtmlAttributes[key] = node.LinkHtmlAttributes[key];
                        }
                    })
                    .Children(item => item.Items)
                )
            );

            return this;
        }

        /// <summary>
        /// Binds the PanelBar to a list of objects. The PanelBar will create a hierarchy of items using the specified mappings.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="factoryAction">The action which will configure the mappings</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .BindTo(Model, mapping => mapping
        ///                     .For&lt;Customer&gt;(binding => binding
        ///                         .Children(c => c.Orders) // The "child" items will be bound to the the "Orders" property
        ///                         .ItemDataBound((item, c) => item.Text = c.ContactName) // Map "Customer" properties to PanelBarItem properties
        ///                     )
        ///                     .For&lt;Order&lt;(binding => binding
        ///                         .Children(o => null) // "Orders" do not have child objects so return "null"
        ///                         .ItemDataBound((item, o) => item.Text = o.OrderID.ToString()) // Map "Order" properties to PanelBarItem properties
        ///                     )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder BindTo(IEnumerable dataSource, Action<NavigationBindingFactory<PanelBarItem>> factoryAction)
        {
            Component.BindTo(dataSource, factoryAction);
            return this;
        }

        /// <summary>
        /// Binds the PanelBar to a list of objects. The PanelBar will be "flat" which means a PanelBar item will be created for
        /// every item in the data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="itemDataBound">The action executed for every data bound item.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .BindTo(new []{"First", "Second"}, (item, value) =>
        ///             {
        ///                item.Text = value;
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder BindTo<T>(IEnumerable<T> dataSource, Action<PanelBarItem, T> itemDataBound)
        {
            Component.BindTo(dataSource, itemDataBound);
            return this;
        }

        /// <summary>
        /// Configures the animation effects of the panelbar.
        /// </summary>
        /// <param name="enable">Whether the component animation is enabled.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .Animation(false)
        /// </code>
        /// </example>
        public PanelBarBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;
        }

        /// <summary>
        /// Configures the animation effects of the panelbar.
        /// </summary>
        /// <param name="animationAction">The action that configures the animation.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .Animation(animation => animation.Expand(config => config.Fade(FadeDirection.In)))
        /// </code>
        /// </example>
        public PanelBarBuilder Animation(Action<ExpandableAnimationBuilder> animationAction)
        {

            animationAction(new ExpandableAnimationBuilder(Component.Animation));

            return this;
        }

        /// <summary>
        /// Callback for each item.
        /// </summary>
        /// <param name="itemAction">Action, which will be executed for each item.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .ItemAction(item =>
        ///             {
        ///                 item
        ///                     .Text(...)
        ///                     .HtmlAttributes(...);
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder ItemAction(Action<PanelBarItem> action)
        {

            Component.ItemAction = action;

            return this;
        }

        /// <summary>
        /// Select item depending on the current URL.
        /// </summary>
        /// <param name="value">If true the item will be highlighted.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .HighlightPath(true)
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder HighlightPath(bool value)
        {
            Component.HighlightPath = value;

            return this;
        }

        /// <summary>
        /// Renders the panelbar with expanded items.
        /// </summary>
        /// <param name="value">If true the panelbar will be expanded.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .ExpandAll(true)
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder ExpandAll(bool value)
        {
            Component.ExpandAll = value;

            return this;
        }

        /// <summary>
        /// Selects the item at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        ///             .SelectedIndex(1)
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarBuilder SelectedIndex(int index)
        {

            Component.SelectedIndex = index;

            return this;
        }
    }
}

