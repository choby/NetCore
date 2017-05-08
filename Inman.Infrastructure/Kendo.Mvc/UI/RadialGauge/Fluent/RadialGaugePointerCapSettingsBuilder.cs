using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugePointerCapSettings
    /// </summary>
    public partial class RadialGaugePointerCapSettingsBuilder
    {
        public RadialGaugePointerCapSettingsBuilder(RadialGaugePointerCapSettings container)
        {
            Container = container;
        }

        protected RadialGaugePointerCapSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The color of the cap.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public RadialGaugePointerCapSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The size of the cap in percents. (from 0 to 1)
        /// </summary>
        /// <param name="value">The value for Size</param>
        public RadialGaugePointerCapSettingsBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// Sets the cap opacity.
        /// </summary>
        /// <param name="opacity">
        /// The cap opacity in the range from 0 (transparent) to 1 (opaque).
        /// The default value is 1.
        /// </param>
        public RadialGaugePointerCapSettingsBuilder Opacity(double opacity)
        {
            Container.Opacity = opacity;
            return this;
        }
    }
}
