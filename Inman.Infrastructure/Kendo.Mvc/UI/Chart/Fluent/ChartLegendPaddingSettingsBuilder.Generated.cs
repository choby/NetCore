using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendPaddingSettings
    /// </summary>
    public partial class ChartLegendPaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the chart legend.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartLegendPaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the chart legend.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartLegendPaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the chart legend.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartLegendPaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the chart legend.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartLegendPaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
