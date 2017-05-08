using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttEditableSettings
    /// </summary>
    public partial class GanttEditableSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttEditableSettingsBuilder(GanttEditableSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttEditableSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
