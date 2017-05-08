using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PanelBarItem
    /// </summary>
    public partial class PanelBarItemBuilder : ContentNavigationItemBuilder<PanelBarItem, PanelBarItemBuilder>

    {
        private readonly PanelBarItem item;
        private readonly ViewContext viewContext;

        public PanelBarItemBuilder(PanelBarItem item, ViewContext viewContext)
            : base(item, viewContext)
        {
            this.item = item;
            this.viewContext = viewContext;
        }

        /// <summary>
        /// Configures the child items of a <see cref="PanelBarItem"/>.
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
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
        public PanelBarItemBuilder Items(Action<PanelBarItemFactory> addAction)
        {
            var factory = new PanelBarItemFactory(item, viewContext);

            addAction(factory);

            return this;
        }

        /// <summary>
        /// Define when the item will be expanded on intial render.
        /// </summary>
        /// <param name="value">If true the item will be expanded.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PanelBar()
        ///             .Name("PanelBar")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item").Items(firstItemChildren => 
        ///                 {
        ///                     firstItemChildren.Add().Text("Child Item 1");
        ///                     firstItemChildren.Add().Text("Child Item 2");
        ///                 })
        ///                 .Expanded(true);
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public PanelBarItemBuilder Expanded(bool value)
        {
            item.Expanded = value;

            return this;
        }
    }
}
