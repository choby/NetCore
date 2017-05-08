using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttCurrentTimeMarkerSettings
    /// </summary>
    public partial class GanttCurrentTimeMarkerSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The update interval of the "current time" marker, in milliseconds.
        /// </summary>
        /// <param name="value">The value for UpdateInterval</param>
        public GanttCurrentTimeMarkerSettingsBuilder<TTaskModel, TDependenciesModel> UpdateInterval(double value)
        {
            Container.UpdateInterval = value;
            return this;
        }

    }
}
