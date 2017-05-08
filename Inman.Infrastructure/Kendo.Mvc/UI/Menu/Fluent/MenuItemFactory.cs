using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<MenuItem>
    /// </summary>
    public partial class MenuItemFactory : IHideObjectMembers

    {
        private readonly ViewContext viewContext;

        public Menu Menu { get; set; }

        public INavigationItemContainer<MenuItem> container { get; set; }

        public MenuItemFactory(INavigationItemContainer<MenuItem> container, ViewContext viewContext)
        {
            this.container = container;
            this.viewContext = viewContext;
        }

        public MenuItemBuilder Add()
        {
            MenuItem item = new MenuItem();

            container.Items.Add(item);

            return new MenuItemBuilder(item, viewContext);
        }
    }
}
