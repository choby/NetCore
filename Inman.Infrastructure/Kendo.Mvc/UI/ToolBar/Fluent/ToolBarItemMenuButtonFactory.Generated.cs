using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Item
    /// </summary>
    public partial class ToolBarItemMenuButtonFactory
        
    {

        public ToolBar ToolBar { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ToolBarItemMenuButtonBuilder Add()
        {
            var item = new ToolBarItemMenuButton();
            item.ToolBar = ToolBar;
            Container.Add(item);

            return new ToolBarItemMenuButtonBuilder(item);
        }
    }
}
