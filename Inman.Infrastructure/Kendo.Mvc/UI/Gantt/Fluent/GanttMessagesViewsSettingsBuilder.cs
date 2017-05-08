using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesViewsSettings
    /// </summary>
    public partial class GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttMessagesViewsSettingsBuilder(GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
