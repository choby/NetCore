using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesActionsSettings
    /// </summary>
    public partial class GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttMessagesActionsSettingsBuilder(GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
