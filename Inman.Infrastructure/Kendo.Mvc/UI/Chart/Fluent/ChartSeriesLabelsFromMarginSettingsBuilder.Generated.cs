using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsFromMarginSettings
    /// </summary>
    public partial class ChartSeriesLabelsFromMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the from labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartSeriesLabelsFromMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the from labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartSeriesLabelsFromMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the from labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartSeriesLabelsFromMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the from labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartSeriesLabelsFromMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
