using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI TreeList
    /// </summary>
    public partial class TreeListColumnFactory<T>
        where T : class 
    {

        public TreeList<T> TreeList { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual TreeListColumnBuilder<T> Add()
        {
            var item = new TreeListColumn<T>();
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListColumnBuilder<T>(item);
        }
    }
}
