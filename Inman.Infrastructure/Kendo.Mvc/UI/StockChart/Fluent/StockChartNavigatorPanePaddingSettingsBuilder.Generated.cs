using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorPanePaddingSettings
    /// </summary>
    public partial class StockChartNavigatorPanePaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public StockChartNavigatorPanePaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public StockChartNavigatorPanePaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public StockChartNavigatorPanePaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the navigator pane.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public StockChartNavigatorPanePaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
