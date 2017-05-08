using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneTitleMarginSettings
    /// </summary>
    public partial class StockChartNavigatorPaneTitleMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the title.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public StockChartNavigatorPaneTitleMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the title.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public StockChartNavigatorPaneTitleMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the title.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public StockChartNavigatorPaneTitleMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the title.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public StockChartNavigatorPaneTitleMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
