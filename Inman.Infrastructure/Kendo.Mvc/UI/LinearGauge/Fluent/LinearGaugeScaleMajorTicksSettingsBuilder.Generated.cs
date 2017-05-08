using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleMajorTicksSettings
    /// </summary>
    public partial class LinearGaugeScaleMajorTicksSettingsBuilder
        
    {
        /// <summary>
        /// The color of the major ticks.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugeScaleMajorTicksSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The major tick size.
		/// This is the length of the line in pixels that is drawn to indicate the tick on the scale.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public LinearGaugeScaleMajorTicksSettingsBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The visibility of the major ticks.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public LinearGaugeScaleMajorTicksSettingsBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The width of the major ticks.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public LinearGaugeScaleMajorTicksSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
