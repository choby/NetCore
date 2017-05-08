using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttMessagesActionsSettings
    /// </summary>
    public partial class GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The text similar to "Add child" displayed as Gantt "add child" buttons.
        /// </summary>
        /// <param name="value">The value for AddChild</param>
        public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> AddChild(string value)
        {
            Container.AddChild = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Append" displayed as Gantt "append" buttons.
        /// </summary>
        /// <param name="value">The value for Append</param>
        public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> Append(string value)
        {
            Container.Append = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Add below" displayed as Gantt "add below" buttons.
        /// </summary>
        /// <param name="value">The value for InsertAfter</param>
        public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> InsertAfter(string value)
        {
            Container.InsertAfter = value;
            return this;
        }

        /// <summary>
        /// The text similar to "Add above" displayed as Gantt "add above" buttons.
        /// </summary>
        /// <param name="value">The value for InsertBefore</param>
        public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> InsertBefore(string value)
        {
            Container.InsertBefore = value;
            return this;
        }

        /// <summary>
        /// The text of "Export to PDF" button of the Gantt toolbar.
        /// </summary>
        /// <param name="value">The value for Pdf</param>
        public GanttMessagesActionsSettingsBuilder<TTaskModel, TDependenciesModel> Pdf(string value)
        {
            Container.Pdf = value;
            return this;
        }

    }
}
