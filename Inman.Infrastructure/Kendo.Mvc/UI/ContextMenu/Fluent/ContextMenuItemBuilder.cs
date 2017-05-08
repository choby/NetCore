using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ContextMenuItem
    /// </summary>
    public partial class ContextMenuItemBuilder : NavigationItemBuilder<ContextMenuItem, ContextMenuItemBuilder>, IHideObjectMembers
        
    {
        private readonly ContextMenuItem item;
        private readonly ViewContext viewContext;

        public ContextMenuItemBuilder(ContextMenuItem container, ViewContext viewContext)
            : base(container, viewContext)
        {
            this.item = container;
            this.viewContext = viewContext;
        }


        /// <summary>
        /// Configures the child items of a <see cref="ContextMenuItem"/>.
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ContextMenu()
        ///             .Name("ContextMenu")
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
        public virtual ContextMenuItemBuilder Items(Action<ContextMenuItemFactory> addAction)
        {

            ContextMenuItemFactory factory = new ContextMenuItemFactory(item, viewContext);

            addAction(factory);

            return this;
        }

        /// <summary>
        /// Configures the child items of a <see cref="ContextMenuItem"/>.
        /// When declaratively binding the menu item, use <see cref="Items(Action<ContextMenuItemFactory>)"/>.
        /// </summary>
        /// <param name="items">items</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ContextMenu()
        ///             .Name("ContextMenu")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item").Items(model);
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public virtual ContextMenuItemBuilder Items(IEnumerable<ContextMenuItem> items)
        {

            item.Items.Clear();

            (items as List<ContextMenuItem>).Each(menuItem => item.Items.Add(menuItem));

            return this;
        }

        /// <summary>
        /// Renders a separator item
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ContextMenu()
        ///             .Name("ContextMenu")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Separator(true);
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public ContextMenuItemBuilder Separator(bool value)
        {
            item.Separator = value;

            return this;
        }
    }
}
