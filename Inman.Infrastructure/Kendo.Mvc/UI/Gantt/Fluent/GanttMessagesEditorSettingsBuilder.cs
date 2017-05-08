using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesEditorSettings
    /// </summary>
    public partial class GanttMessagesEditorSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttMessagesEditorSettingsBuilder(GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttMessagesEditorSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
