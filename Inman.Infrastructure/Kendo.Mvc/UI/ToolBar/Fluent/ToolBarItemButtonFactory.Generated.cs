using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Item
    /// </summary>
    public partial class ToolBarItemButtonFactory
        
    {

        public ToolBar ToolBar { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ToolBarItemButtonBuilder Add()
        {
            var item = new ToolBarItemButton();
            item.ToolBar = ToolBar;
            Container.Add(item);

            return new ToolBarItemButtonBuilder(item);
        }
    }
}
