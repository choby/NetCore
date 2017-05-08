using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<TabStripItem>
    /// </summary>
    public class TabStripItemFactory : IHideObjectMembers
    {
        private readonly INavigationItemContainer<TabStripItem> container;
        private readonly ViewContext viewContext;

        public TabStripItemFactory(INavigationItemContainer<TabStripItem> container, ViewContext viewContext)
        {

            this.container = container;
            this.viewContext = viewContext;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual TabStripItemBuilder Add()
        {
            var item = new TabStripItem();

            container.Items.Add(item);

            return new TabStripItemBuilder(item, viewContext);
        }
    }
}
