using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeGaugeAreaMarginSettings
    /// </summary>
    public partial class RadialGaugeGaugeAreaMarginSettingsBuilder
        
    {
        /// <summary>
        /// The top margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public RadialGaugeGaugeAreaMarginSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

        /// <summary>
        /// The bottom margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public RadialGaugeGaugeAreaMarginSettingsBuilder Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public RadialGaugeGaugeAreaMarginSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right margin of the gauge area.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public RadialGaugeGaugeAreaMarginSettingsBuilder Right(double value)
        {
            Container.Right = value;
            return this;
        }

    }
}
