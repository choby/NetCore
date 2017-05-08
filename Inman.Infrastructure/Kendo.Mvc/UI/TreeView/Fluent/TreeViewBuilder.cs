using Kendo.Mvc.UI.Fluent;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeView
    /// </summary>
    public partial class TreeViewBuilder : WidgetBuilderBase<TreeView, TreeViewBuilder>, IHideObjectMembers
    {
        public TreeViewBuilder(TreeView component) : base(component)
        {
        }

        /// <summary>
        /// Defines the items in the TreeView
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder Items(Action<TreeViewItemFactory> addAction)
        {
            TreeViewItemFactory factory = new TreeViewItemFactory(Component, Component.ViewContext);
            addAction(factory);
            return this;
        }

        /// <summary>
        /// Select item depending on the current URL.
        /// </summary>
        /// <param name="value">If true the item will be highlighted.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .HighlightPath(true)
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder HighlightPath(bool value)
        {
            Component.HighlightPath = value;
            return this;
        }

        /// <summary>
        /// Expand all the items.
        /// </summary>
        /// <param name="value">If true all the items will be expanded.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .ExpandAll(true)
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder ExpandAll(bool value)
        {
            Component.ExpandAll = value;
            return this;
        }

        /// <summary>
        /// Configure the DataSource of the component
        /// </summary>
        /// <param name="configurator">The action that configures the <see cref="DataSource"/>.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///     .Name("TreeView")
        ///     .DataSource(dataSource => dataSource
        ///         .Read(read => read
        ///             .Action("Employees", "TreeView")
        ///         )
        ///     )
        ///  %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder DataSource(Action<HierarchicalDataSourceBuilder<object>> configurator)
        {
            configurator(new HierarchicalDataSourceBuilder<object>(Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));

            return this;
        }
        /// <summary>
        /// Set ID of the DataSource that to be used for data binding
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <returns></returns>
        public TreeViewBuilder DataSource(string dataSourceId)
        {
            this.Component.DataSourceId = dataSourceId;

            return this;
        }

        /// <summary>
        /// Binds the TreeView to a list of items.
        /// Use if a hierarchy of items is being sent from the controller; to bind the TreeView declaratively, use the Items() method.
        /// </summary>
        /// <param name="items">The list of items</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .BindTo(model)
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder BindTo(IEnumerable<TreeViewItemModel> items)
        {
            Component.BindTo(items, mapping => mapping
                .For<TreeViewItemModel>(binding => binding
                    .ItemDataBound((item, node) =>
                    {
                        item.Text = node.Text;
                        item.Enabled = node.Enabled;
                        item.Expanded = node.Expanded;
                        item.Encoded = node.Encoded;
                        item.Id = node.Id;
                        item.Checked = node.Checked;
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
        /// Binds the TreeView to a list of objects. The TreeView will create a hierarchy of items using the specified mappings.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="factoryAction">The action which will configure the mappings</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .BindTo(Model, mapping => mapping
        ///                     .For&lt;Customer&gt;(binding => binding
        ///                         .Children(c => c.Orders) // The "child" items will be bound to the the "Orders" property
        ///                         .ItemDataBound((item, c) => item.Text = c.ContactName) // Map "Customer" properties to TreeViewItem properties
        ///                     )
        ///                     .For&lt;Order&lt;(binding => binding
        ///                         .Children(o => null) // "Orders" do not have child objects so return "null"
        ///                         .ItemDataBound((item, o) => item.Text = o.OrderID.ToString()) // Map "Order" properties to TreeViewItem properties
        ///                     )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder BindTo(IEnumerable dataSource, Action<NavigationBindingFactory<TreeViewItem>> factoryAction)
        {
            Component.BindTo(dataSource, factoryAction);
            return this;
        }

        /// <summary>
        /// Binds the TreeView to a list of objects. The TreeView will be "flat" which means a TreeView item will be created for
        /// every item in the data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="itemDataBound">The action executed for every data bound item.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .BindTo(new []{"First", "Second"}, (item, value) =>
        ///             {
        ///                item.Text = value;
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder BindTo<T>(IEnumerable<T> dataSource, Action<TreeViewItem, T> itemDataBound)
        {
            Component.BindTo(dataSource, itemDataBound);
            return this;
        }

        /// <summary>
        /// Use to enable or disable animation of the TreeView.
        /// </summary>
        /// <param name="enable">The boolean value.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().TreeView()
        ///	           .Name("TreeView")
        ///	           .Animation(false) //toggle effect
        ///	%&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;
        }

        /// <summary>
        /// Configures the animation effects of the widget.
        /// </summary>
        /// <param name="animationAction">The action which configures the animation effects.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().TreeView()
        ///	           .Name("TreeView")
        ///	           .Animation(animation =>
        ///	           {
        ///		            animation.Expand(open =>
        ///		            {
        ///		                open.SlideIn(SlideDirection.Down);
        ///		            });
        ///	           })
        ///	%&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder Animation(Action<ExpandableAnimationBuilder> animationAction)
        {

            animationAction(new ExpandableAnimationBuilder(Component.Animation));

            return this;
        }

        /// <summary>
        /// Template to be used for rendering the item checkboxes in the treeview.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .CheckboxTemplate("#= data #")
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder CheckboxTemplate(string template)
        {
            return Checkboxes(config => config.Template(template));
        }

        /// <summary>
        /// Id of the template element to be used for rendering the item checkboxes in the treeview.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeView()
        ///             .Name("TreeView")
        ///             .CheckboxTemplateId("widgetTemplateId")
        /// %&gt;
        /// </code>
        /// </example>
        public TreeViewBuilder CheckboxTemplateId(string templateId)
        {
            return Checkboxes(config => config.TemplateId(templateId));
        }
    }
}

