using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Gantt
    /// </summary>
    public partial class GanttToolbarFactory<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {

        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        /// <summary>
        /// Adds an item for a custom action.
        /// </summary>
        public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Custom()
        {
            var item = new GanttToolbar<TTaskModel, TDependenciesModel>();
            item.Gantt = Gantt;
            Container.Add(item);

            return new GanttToolbarBuilder<TTaskModel, TDependenciesModel>(item);
        }

        /// <summary>
        /// Adds an item for the append action.
        /// </summary>
        public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Append()
        {
            var item = new GanttToolbar<TTaskModel, TDependenciesModel>() { Name = "append" };
            item.Gantt = Gantt;
            Container.Add(item);

            return new GanttToolbarBuilder<TTaskModel, TDependenciesModel>(item);
        }

        /// <summary>
        /// Adds an item for the pdf action.
        /// </summary>
        public virtual GanttToolbarBuilder<TTaskModel, TDependenciesModel> Pdf()
        {
            var item = new GanttToolbar<TTaskModel, TDependenciesModel>() { Name = "pdf" };
            item.Gantt = Gantt;
            Container.Add(item);

            return new GanttToolbarBuilder<TTaskModel, TDependenciesModel>(item);
        }
    }
}
