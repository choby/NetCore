using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Gantt
    /// </summary>
    public partial class GanttViewFactory<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {

        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> Add()
        {
            var item = new GanttView<TTaskModel, TDependenciesModel>();
            item.Gantt = Gantt;
            Container.Add(item);

            return new GanttViewBuilder<TTaskModel, TDependenciesModel>(item);
        }
    }
}
