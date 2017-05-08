using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttRangeSettings
    /// </summary>
    public partial class GanttRangeSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttRangeSettingsBuilder(GanttRangeSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttRangeSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
