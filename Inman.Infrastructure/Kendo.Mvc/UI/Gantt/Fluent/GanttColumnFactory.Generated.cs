using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Gantt
    /// </summary>
    public partial class GanttColumnFactory<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {

        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual GanttColumnBuilder<TTaskModel, TDependenciesModel> Add()
        {
            var item = new GanttColumn<TTaskModel, TDependenciesModel>();
            item.Gantt = Gantt;
            Container.Add(item);

            return new GanttColumnBuilder<TTaskModel, TDependenciesModel>(item);
        }
    }
}
