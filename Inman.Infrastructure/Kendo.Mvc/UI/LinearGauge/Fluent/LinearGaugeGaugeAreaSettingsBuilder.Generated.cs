using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeGaugeAreaSettings
    /// </summary>
    public partial class LinearGaugeGaugeAreaSettingsBuilder
        
    {
        /// <summary>
        /// The border of the gauge area.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public LinearGaugeGaugeAreaSettingsBuilder Border(Action<LinearGaugeGaugeAreaBorderSettingsBuilder> configurator)
        {

            Container.Border.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeGaugeAreaBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// The height of the gauge area.  By default, the vertical gauge is 200px and
		/// the horizontal one is 60px.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public LinearGaugeGaugeAreaSettingsBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The margin of the gauge area.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public LinearGaugeGaugeAreaSettingsBuilder Margin(Action<LinearGaugeGaugeAreaMarginSettingsBuilder> configurator)
        {

            Container.Margin.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeGaugeAreaMarginSettingsBuilder(Container.Margin));

            return this;
        }

        /// <summary>
        /// The width of the gauge area.  By default the vertical gauge is 60px and
		/// horizontal gauge is 200px.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public LinearGaugeGaugeAreaSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The background of the gauge area. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public LinearGaugeGaugeAreaSettingsBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

    }
}
