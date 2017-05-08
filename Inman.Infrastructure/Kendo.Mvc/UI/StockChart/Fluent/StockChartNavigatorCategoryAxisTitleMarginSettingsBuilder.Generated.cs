using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitleMarginSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the title.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the title.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the title.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the title.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
