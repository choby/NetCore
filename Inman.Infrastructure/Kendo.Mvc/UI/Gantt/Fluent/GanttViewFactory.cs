using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<GanttView<TTaskModel, TDependenciesModel>>
    /// </summary>
    public partial class GanttViewFactory<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttViewFactory(List<GanttView<TTaskModel, TDependenciesModel>> container)
        {
            Container = container;
        }

        protected List<GanttView<TTaskModel, TDependenciesModel>> Container
        {
            get;
            private set;
        }

        private GanttViewBuilder<TTaskModel, TDependenciesModel> Add(GanttViewType type)
        {
            var view = new GanttView<TTaskModel, TDependenciesModel> { Type = type };
            view.Gantt = Gantt;
            Container.Add(view);

            return new GanttViewBuilder<TTaskModel, TDependenciesModel>(view);
        }

        public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> DayView(Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
        {
            var builder = Add(GanttViewType.Day);

            addViewAction(builder);

            return builder;
        }

        public void DayView()
        {
            Add(GanttViewType.Day);
        }

        public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> WeekView(Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
        {
            var builder = Add(GanttViewType.Week);

            addViewAction(builder);

            return builder;
        }

        public void WeekView()
        {
            Add(GanttViewType.Week);
        }

        public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> MonthView(Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
        {
            var builder = Add(GanttViewType.Month);

            addViewAction(builder);

            return builder;
        }

        public void MonthView()
        {
            Add(GanttViewType.Month);
        }

        public virtual GanttViewBuilder<TTaskModel, TDependenciesModel> YearView(Action<GanttViewBuilder<TTaskModel, TDependenciesModel>> addViewAction)
        {
            var builder = Add(GanttViewType.Year);

            addViewAction(builder);

            return builder;
        }

        public void YearView()
        {
            Add(GanttViewType.Year);
        }
    }
}
