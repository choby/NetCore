using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsMarginSettings
    /// </summary>
    public partial class ChartYAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartYAxisLabelsMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartYAxisLabelsMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartYAxisLabelsMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartYAxisLabelsMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
