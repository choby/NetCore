using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttRangeSettings
    /// </summary>
    public partial class GanttRangeSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// If set to some date the timeline of all views will start from this date.
        /// </summary>
        /// <param name="value">The value for Start</param>
        public GanttRangeSettingsBuilder<TTaskModel, TDependenciesModel> Start(DateTime value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// If set to some date the timeline of all views will end to this date.
        /// </summary>
        /// <param name="value">The value for End</param>
        public GanttRangeSettingsBuilder<TTaskModel, TDependenciesModel> End(DateTime value)
        {
            Container.End = value;
            return this;
        }

    }
}
