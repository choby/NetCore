using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleSettingsRange
    /// </summary>
    public partial class LinearGaugeScaleSettingsRangeBuilder
        
    {
        /// <summary>
        /// The start position of the range in scale units.
        /// </summary>
        /// <param name="value">The value for From</param>
        public LinearGaugeScaleSettingsRangeBuilder From(double value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The end position of the range in scale units.
        /// </summary>
        /// <param name="value">The value for To</param>
        public LinearGaugeScaleSettingsRangeBuilder To(double value)
        {
            Container.To = value;
            return this;
        }

        /// <summary>
        /// The opacity of the range.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public LinearGaugeScaleSettingsRangeBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The color of the range.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugeScaleSettingsRangeBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

    }
}
