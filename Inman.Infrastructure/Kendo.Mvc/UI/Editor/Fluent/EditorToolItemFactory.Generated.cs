using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Tool
    /// </summary>
    public partial class EditorToolItemFactory
        
    {

        public Editor Editor { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual EditorToolItemBuilder Add()
        {
            var item = new EditorToolItem();
            item.Editor = Editor;
            Container.Add(item);

            return new EditorToolItemBuilder(item);
        }
    }
}
