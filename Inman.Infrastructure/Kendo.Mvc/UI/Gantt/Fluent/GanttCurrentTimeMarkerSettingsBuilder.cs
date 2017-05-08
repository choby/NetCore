using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttCurrentTimeMarkerSettings
    /// </summary>
    public partial class GanttCurrentTimeMarkerSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttCurrentTimeMarkerSettingsBuilder(GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
