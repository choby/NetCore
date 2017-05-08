using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttViewRangeSettings
    /// </summary>
    public partial class GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttViewRangeSettingsBuilder(GanttViewRangeSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttViewRangeSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
