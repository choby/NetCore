using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttTooltipSettings
    /// </summary>
    public partial class GanttTooltipSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttTooltipSettingsBuilder(GanttTooltipSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttTooltipSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
