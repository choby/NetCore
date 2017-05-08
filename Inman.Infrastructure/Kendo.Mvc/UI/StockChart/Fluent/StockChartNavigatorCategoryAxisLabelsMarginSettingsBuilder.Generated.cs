using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsMarginSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
