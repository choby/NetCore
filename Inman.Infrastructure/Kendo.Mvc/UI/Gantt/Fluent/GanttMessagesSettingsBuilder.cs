using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesSettings
    /// </summary>
    public partial class GanttMessagesSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttMessagesSettingsBuilder(GanttMessagesSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttMessagesSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
