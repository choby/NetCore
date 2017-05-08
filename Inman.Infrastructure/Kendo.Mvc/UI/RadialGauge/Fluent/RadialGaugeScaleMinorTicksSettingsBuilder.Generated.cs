using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleMinorTicksSettings
    /// </summary>
    public partial class RadialGaugeScaleMinorTicksSettingsBuilder
        
    {
        /// <summary>
        /// The color of the minor ticks.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public RadialGaugeScaleMinorTicksSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The minor tick size.
		/// This is the length of the line in pixels that is drawn to indicate the tick on the scale.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public RadialGaugeScaleMinorTicksSettingsBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The visibility of the minor ticks.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public RadialGaugeScaleMinorTicksSettingsBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the minor ticks.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public RadialGaugeScaleMinorTicksSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
