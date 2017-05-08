using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI TreeList
    /// </summary>
    public partial class TreeListToolbarFactory<T>
        where T : class 
    {

        public TreeList<T> TreeList { get; set; }

        /// <summary>
        /// Adds an item for a custom action.
        /// </summary>
        public virtual TreeListToolbarBuilder<T> Custom()
        {
            var item = new TreeListToolbar<T>();
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListToolbarBuilder<T>(item);
        }

        /// <summary>
        /// Adds an item for the create action.
        /// </summary>
        public virtual TreeListToolbarBuilder<T> Create()
        {
            var item = new TreeListToolbar<T>() { Name = "create" };
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListToolbarBuilder<T>(item);
        }

        /// <summary>
        /// Adds an item for the excel action.
        /// </summary>
        public virtual TreeListToolbarBuilder<T> Excel()
        {
            var item = new TreeListToolbar<T>() { Name = "excel" };
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListToolbarBuilder<T>(item);
        }

        /// <summary>
        /// Adds an item for the pdf action.
        /// </summary>
        public virtual TreeListToolbarBuilder<T> Pdf()
        {
            var item = new TreeListToolbar<T>() { Name = "pdf" };
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListToolbarBuilder<T>(item);
        }
    }
}
