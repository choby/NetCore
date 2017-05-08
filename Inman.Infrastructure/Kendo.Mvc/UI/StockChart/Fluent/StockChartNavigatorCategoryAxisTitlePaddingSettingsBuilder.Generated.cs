using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitlePaddingSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the title.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the title.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the title.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the title.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
