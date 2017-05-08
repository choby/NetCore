using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsCrosshairTooltipPaddingSettings
    /// </summary>
    public partial class ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the crosshair tooltip.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the crosshair tooltip.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the crosshair tooltip.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the crosshair tooltip.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
