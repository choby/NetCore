using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeGaugeAreaSettings
    /// </summary>
    public partial class RadialGaugeGaugeAreaSettingsBuilder
        
    {
        /// <summary>
        /// The border of the gauge area.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public RadialGaugeGaugeAreaSettingsBuilder Border(Action<RadialGaugeGaugeAreaBorderSettingsBuilder> configurator)
        {

            Container.Border.RadialGauge = Container.RadialGauge;
            configurator(new RadialGaugeGaugeAreaBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// The height of the gauge area.  By default, the vertical gauge is 200px and
		/// the horizontal one is 60px.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public RadialGaugeGaugeAreaSettingsBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The margin of the gauge area.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public RadialGaugeGaugeAreaSettingsBuilder Margin(Action<RadialGaugeGaugeAreaMarginSettingsBuilder> configurator)
        {

            Container.Margin.RadialGauge = Container.RadialGauge;
            configurator(new RadialGaugeGaugeAreaMarginSettingsBuilder(Container.Margin));

            return this;
        }

        /// <summary>
        /// The width of the gauge area.  By default the vertical gauge is 60px
		/// and horizontal gauge is 200px.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public RadialGaugeGaugeAreaSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The background of the gauge area. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public RadialGaugeGaugeAreaSettingsBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

    }
}
