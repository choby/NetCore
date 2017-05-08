using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<EditorToolItem>
    /// </summary>
    public partial class EditorToolItemFactory

    {
        public EditorToolItemFactory(List<EditorToolItem> container)
        {
            Container = container;
        }

        protected List<EditorToolItem> Container
        {
            get;
            private set;
        }

        // Place custom settings here
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public EditorToolItemFactory Add(string text, string value)
        {
            var item = new EditorToolItem()
            {
                Text = text,
                Value = value
            };
            Container.Add(item);

            return this;
        }
    }
}
