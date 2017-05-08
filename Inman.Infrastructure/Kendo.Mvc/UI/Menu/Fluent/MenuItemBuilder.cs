using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MenuItem
    /// </summary>
    public partial class MenuItemBuilder : NavigationItemBuilder<MenuItem, MenuItemBuilder>, IHideObjectMembers

    {
        private readonly MenuItem item;
        private readonly ViewContext viewContext;

        public MenuItemBuilder(MenuItem container, ViewContext viewContext)
            : base(container, viewContext)
        {
            this.item = container;
            this.viewContext = viewContext;
        }


        /// <summary>
        /// Configures the child items of a <see cref="MenuItem"/>.
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().tMenu()
        ///             .Name("Menu")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item").Items(firstItemChildren => 
        ///                 {
        ///                     firstItemChildren.Add().Text("Child Item 1");
        ///                     firstItemChildren.Add().Text("Child Item 2");
        ///                 });
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public virtual MenuItemBuilder Items(Action<MenuItemFactory> addAction)
        {

            MenuItemFactory factory = new MenuItemFactory(item, viewContext);

            addAction(factory);

            return this;
        }

        /// <summary>
        /// Configures the child items of a <see cref="MenuItem"/>.
        /// When declaratively binding the menu item, use <see cref="Items(Action<MenuItemFactory>)"/>.
        /// </summary>
        /// <param name="items">items</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item").Items(model);
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public virtual MenuItemBuilder Items(IEnumerable<MenuItem> items)
        {

            item.Items.Clear();

            (items as List<MenuItem>).Each(menuItem => item.Items.Add(menuItem));

            return this;
        }

        /// <summary>
        /// Renders a separator item
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Menu()
        ///             .Name("Menu")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Separator(true);
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public MenuItemBuilder Separator(bool value)
        {
            item.Separator = value;

            return this;
        }
    }
}
