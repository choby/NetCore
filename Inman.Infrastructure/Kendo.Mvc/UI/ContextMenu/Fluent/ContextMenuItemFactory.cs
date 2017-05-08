using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ContextMenuItem>
    /// </summary>
    public partial class ContextMenuItemFactory : IHideObjectMembers
        
    {
        private readonly ViewContext viewContext;

        public ContextMenu ContextMenu { get; set; }

        public INavigationItemContainer<ContextMenuItem> container { get; set; }

        public ContextMenuItemFactory(INavigationItemContainer<ContextMenuItem> container, ViewContext viewContext)
        {
            this.container = container;
            this.viewContext = viewContext;
        }

        public ContextMenuItemBuilder Add()
        {
            ContextMenuItem item = new ContextMenuItem();

            container.Items.Add(item);

            return new ContextMenuItemBuilder(item, viewContext);
        }
    }
}
