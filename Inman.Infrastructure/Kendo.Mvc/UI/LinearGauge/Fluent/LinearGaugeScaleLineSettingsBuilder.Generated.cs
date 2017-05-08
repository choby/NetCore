using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleLineSettings
    /// </summary>
    public partial class LinearGaugeScaleLineSettingsBuilder
        
    {
        /// <summary>
        /// The color of the lines. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugeScaleLineSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the line.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public LinearGaugeScaleLineSettingsBuilder DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The visibility of the lines.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public LinearGaugeScaleLineSettingsBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the line..
        /// </summary>
        /// <param name="value">The value for Width</param>
        public LinearGaugeScaleLineSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
