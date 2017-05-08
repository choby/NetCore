using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPanePaddingSettings
    /// </summary>
    public partial class ChartPanePaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the chart panes.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartPanePaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the chart panes.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartPanePaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the chart panes.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartPanePaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the chart panes.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartPanePaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
