using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeGaugeAreaBorderSettings
    /// </summary>
    public partial class RadialGaugeGaugeAreaBorderSettingsBuilder
        
    {
        /// <summary>
        /// The color of the border. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public RadialGaugeGaugeAreaBorderSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the border.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public RadialGaugeGaugeAreaBorderSettingsBuilder DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The opacity of the border. By default the border is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public RadialGaugeGaugeAreaBorderSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public RadialGaugeGaugeAreaBorderSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
