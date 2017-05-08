using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTooltipPaddingSettings
    /// </summary>
    public partial class ChartTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the tooltip.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartTooltipPaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the tooltip.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartTooltipPaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the tooltip.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartTooltipPaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the tooltip.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartTooltipPaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
