using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPaneMarginSettings
    /// </summary>
    public partial class StockChartNavigatorPaneMarginSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom margin of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public StockChartNavigatorPaneMarginSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public StockChartNavigatorPaneMarginSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public StockChartNavigatorPaneMarginSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top margin of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public StockChartNavigatorPaneMarginSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
