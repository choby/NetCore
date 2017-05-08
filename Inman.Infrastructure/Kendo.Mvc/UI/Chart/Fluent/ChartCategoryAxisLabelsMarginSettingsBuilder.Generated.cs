using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsMarginSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartCategoryAxisLabelsMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartCategoryAxisLabelsMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartCategoryAxisLabelsMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartCategoryAxisLabelsMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
