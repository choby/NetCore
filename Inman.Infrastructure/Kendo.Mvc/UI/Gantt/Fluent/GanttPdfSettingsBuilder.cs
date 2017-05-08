using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttPdfSettings
    /// </summary>
    public partial class GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttPdfSettingsBuilder(GanttPdfSettings<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttPdfSettings<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
