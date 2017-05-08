using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TabStripItem
    /// </summary>
    public class TabStripItemBuilder : ContentNavigationItemBuilder<TabStripItem, TabStripItemBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TabStripItemBuilder"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="viewContext">The context of the View.</param>
        public TabStripItemBuilder(TabStripItem item, ViewContext viewContext)
            : base(item, viewContext)
        {

        }
    }
}
