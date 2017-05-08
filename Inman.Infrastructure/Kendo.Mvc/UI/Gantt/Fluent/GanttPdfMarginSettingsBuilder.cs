using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttPdfMarginSettings
    /// </summary>
    public partial class GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttPdfMarginSettingsBuilder(GanttPdfMarginSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttPdfMarginSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
