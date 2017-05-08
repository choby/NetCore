using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttToolbar
    /// </summary>
    public partial class GanttToolbarBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttToolbarBuilder(GanttToolbar<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttToolbar<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
