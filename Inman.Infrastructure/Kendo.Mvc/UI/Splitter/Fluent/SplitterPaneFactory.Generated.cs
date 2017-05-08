using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Splitter
    /// </summary>
    public partial class SplitterPaneFactory
        
    {

        public Splitter Splitter { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SplitterPaneBuilder Add()
        {
            var item = new SplitterPane();
            item.Splitter = Splitter;
            Container.Add(item);

            return new SplitterPaneBuilder(item);
        }
    }
}
