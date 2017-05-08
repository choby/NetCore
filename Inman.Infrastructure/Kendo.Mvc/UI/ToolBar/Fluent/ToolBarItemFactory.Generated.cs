using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI ToolBar
    /// </summary>
    public partial class ToolBarItemFactory
        
    {

        public ToolBar ToolBar { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ToolBarItemBuilder Add()
        {
            var item = new ToolBarItem();
            item.ToolBar = ToolBar;
            Container.Add(item);

            return new ToolBarItemBuilder(item);
        }
    }
}
