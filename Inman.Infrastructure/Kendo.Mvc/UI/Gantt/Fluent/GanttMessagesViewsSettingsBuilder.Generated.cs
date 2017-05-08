using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesViewsSettings
    /// </summary>
    public partial class GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The text similar to "Day" displayed as Gantt "day" view title.
        /// </summary>
        /// <param name="value">The value for Day</param>
        public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Day(string value)
        {
            Container.Day = value;
            return this;
        }

        /// <summary>
        /// The text similar to "End" displayed in Gantt resize hint.
        /// </summary>
        /// <param name="value">The value for End</param>
        public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> End(string value)
        {
            Container.End = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Month" displayed as Gantt "month" view title.
        /// </summary>
        /// <param name="value">The value for Month</param>
        public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Month(string value)
        {
            Container.Month = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Start" displayed in Gantt resize hint.
        /// </summary>
        /// <param name="value">The value for Start</param>
        public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Start(string value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Week" displayed as Gantt "week" view title.
        /// </summary>
        /// <param name="value">The value for Week</param>
        public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Week(string value)
        {
            Container.Week = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Year" displayed as Gantt "year" view title.
        /// </summary>
        /// <param name="value">The value for Year</param>
        public GanttMessagesViewsSettingsBuilder<TTaskModel, TDependenciesModel> Year(string value)
        {
            Container.Year = value;
            return this;
        }

    }
}
