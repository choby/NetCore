using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttViewRangeSettings
    /// </summary>
    public partial class GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// If set to some date the timeline of the view will start from this date.Overrides the range.start option of the gantt.
        /// </summary>
        /// <param name="value">The value for Start</param>
        public GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel> Start(DateTime value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// If set to some date the timeline of the view will end to this date.Overrides the range.end option of the gantt.
        /// </summary>
        /// <param name="value">The value for End</param>
        public GanttViewRangeSettingsBuilder<TTaskModel, TDependenciesModel> End(DateTime value)
        {
            Container.End = value;
            return this;
        }

    }
}
