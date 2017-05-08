using System;
using System.Collections;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Menu
    /// </summary>
    public partial class MenuBuilder: WidgetBuilderBase<Menu, MenuBuilder>
        
    {
        public MenuBuilder(Menu component) : base(component)
        {
        }

        public MenuBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;
        }

        public MenuBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {
            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this;
        }

        /// <summary>
        /// Defines the items in the menu
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public MenuBuilder Items(Action<MenuItemFactory> addAction)
        {
            MenuItemFactory factory = new MenuItemFactory(Component, Component.ViewContext);

            addAction(factory);

            return this;
        }

        /// <summary>
        /// Specifies Menu opening direction.
        /// </summary>
        /// <param name="value">The desired direction.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .Direction("top")
        /// %&gt;
        /// </code>
        /// </example>
        public MenuBuilder Direction(string value)
        {
            Component.Direction = value;

            return this;
        }

        public MenuBuilder Direction(MenuDirection value)
        {
            Component.Direction = value.ToString().ToLower();

            return this;
        }

        /// <summary>
        /// Binds the menu to a sitemap
        /// </summary>
        /// <param name="viewDataKey">The view data key.</param>
        /// <param name="siteMapAction">The action to configure the item.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .BindTo("examples", (item, siteMapNode) =>
        ///             {
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        //public MenuBuilder BindTo(string viewDataKey, Action<MenuItem, SiteMapNode> siteMapAction)
        //{
        //    Component.BindTo(viewDataKey, siteMapAction);

        //    return this;
        //}


        /// <summary>
        /// Binds the menu to a sitemap.
        /// </summary>
        /// <param name="viewDataKey">The view data key.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .BindTo("examples")
        /// %&gt;
        /// </code>
        /// </example>
        //public MenuBuilder BindTo(string viewDataKey)
        //{
        //    Component.BindTo(viewDataKey);

        //    return this;
        //}

        /// <summary>
        /// Binds the menu to a list of objects. The menu will be "flat" which means a menu item will be created for
        /// every item in the data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="itemDataBound">The action executed for every data bound item.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .BindTo(new []{"First", "Second"}, (item, value) =>
        ///             {
        ///                item.Text = value;
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public MenuBuilder BindTo<T>(IEnumerable<T> dataSource, Action<MenuItem, T> itemDataBound)
        {
            Component.BindTo(dataSource, itemDataBound);

            return this;
        }

        /// <summary>
        /// Binds the menu to a list of objects. The menu will create a hierarchy of items using the specified mappings.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <param name="factoryAction">The action which will configure the mappings</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .BindTo(Model, mapping => mapping
        ///                     .For&lt;Customer&gt;(binding => binding
        ///                         .Children(c => c.Orders) // The "child" items will be bound to the the "Orders" property
        ///                         .ItemDataBound((item, c) => item.Text = c.ContactName) // Map "Customer" properties to MenuItem properties
        ///                     )
        ///                     .For&lt;Order&lt;(binding => binding
        ///                         .Children(o => null) // "Orders" do not have child objects so return "null"
        ///                         .ItemDataBound((item, o) => item.Text = o.OrderID.ToString()) // Map "Order" properties to MenuItem properties
        ///                     )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public MenuBuilder BindTo(IEnumerable dataSource, Action<NavigationBindingFactory<MenuItem>> factoryAction)
        {
            Component.BindTo(dataSource, factoryAction);

            return this;
        }

        /// <summary>
        /// Binds the menu to a list of items.
        /// Use if the menu items are being sent from the controller.
        /// To bind the Menu declaratively, use the <seealso cref="Items(Action<MenuItemFactory>)"> method.
        /// </summary>
        /// <param name="items">The list of items</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("TreeView")
        ///             .BindTo(model)
        /// %&gt;
        /// </code>
        /// </example>
        public MenuBuilder BindTo(IEnumerable<MenuItem> items)
        {
            Component.Items.Clear();

            foreach (MenuItem item in items)
            {
                Component.Items.Add(item);
            }

            return this;
        }

        public MenuBuilder ItemAction(Action<MenuItem> action)
        {
            Component.ItemAction = action;

            return this;
        }

        public MenuBuilder HighlightPath(bool value)
        {
            Component.HighlightPath = value;

            return this;
        }

        //public MenuBuilder SecurityTrimming(bool value)
        //{
        //    Component.SecurityTrimming.Enabled = value;

        //    return this;
        //}

        //public MenuBuilder SecurityTrimming(Action<SecurityTrimmingBuilder> securityTrimmingAction)
        //{
        //    securityTrimmingAction(new SecurityTrimmingBuilder(Component.SecurityTrimming));

        //    return this;
        //}
    }
}

