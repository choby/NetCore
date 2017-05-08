using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsToMarginSettings
    /// </summary>
    public partial class ChartSeriesLabelsToMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the to labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartSeriesLabelsToMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the to labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartSeriesLabelsToMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the to labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartSeriesLabelsToMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the to labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartSeriesLabelsToMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
