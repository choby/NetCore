using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeGaugeAreaMarginSettings
    /// </summary>
    public partial class LinearGaugeGaugeAreaMarginSettingsBuilder
        
    {
        /// <summary>
        /// The top margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public LinearGaugeGaugeAreaMarginSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

        /// <summary>
        /// The bottom margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public LinearGaugeGaugeAreaMarginSettingsBuilder Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public LinearGaugeGaugeAreaMarginSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public LinearGaugeGaugeAreaMarginSettingsBuilder Right(double value)
        {
            Container.Right = value;
            return this;
        }

    }
}
