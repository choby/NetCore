using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodeBorderSettings
    /// </summary>
    public partial class BarcodeBorderSettingsBuilder
        
    {
        /// <summary>
        /// The color of the border. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public BarcodeBorderSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the border.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public BarcodeBorderSettingsBuilder DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public BarcodeBorderSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
