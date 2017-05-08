using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Column
    /// </summary>
    public partial class TreeListColumnCommandFactory<T>
        where T : class 
    {

        public TreeList<T> TreeList { get; set; }

        /// <summary>
        /// Adds an item for a custom action.
        /// </summary>
        public virtual TreeListColumnCommandBuilder<T> Custom()
        {
            var item = new TreeListColumnCommand<T>();
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListColumnCommandBuilder<T>(item);
        }

        /// <summary>
        /// Adds an item for the edit action.
        /// </summary>
        public virtual TreeListColumnCommandBuilder<T> Edit()
        {
            var item = new TreeListColumnCommand<T>() { Name = "edit" };
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListColumnCommandBuilder<T>(item);
        }

        /// <summary>
        /// Adds an item for the createChild action.
        /// </summary>
        public virtual TreeListColumnCommandBuilder<T> CreateChild()
        {
            var item = new TreeListColumnCommand<T>() { Name = "createChild" };
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListColumnCommandBuilder<T>(item);
        }

        /// <summary>
        /// Adds an item for the destroy action.
        /// </summary>
        public virtual TreeListColumnCommandBuilder<T> Destroy()
        {
            var item = new TreeListColumnCommand<T>() { Name = "destroy" };
            item.TreeList = TreeList;
            Container.Add(item);

            return new TreeListColumnCommandBuilder<T>(item);
        }
    }
}
