using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttPdfMarginSettings
    /// </summary>
    public partial class GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        /// <summary>
        /// The bottom margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin. Numbers are considered as "pt" units.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
