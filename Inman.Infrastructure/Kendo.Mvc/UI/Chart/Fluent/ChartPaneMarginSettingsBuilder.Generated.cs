using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneMarginSettings
    /// </summary>
    public partial class ChartPaneMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the chart panes.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartPaneMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the chart panes.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartPaneMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the chart panes.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartPaneMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the chart panes.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartPaneMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
