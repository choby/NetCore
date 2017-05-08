using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI RadialGauge
    /// </summary>
    public partial class RadialGaugeBuilder
        
    {
        /// <summary>
        /// The gauge area configuration options.
		/// This is the entire visible area of the gauge.
        /// </summary>
        /// <param name="configurator">The configurator for the gaugearea setting.</param>
        public RadialGaugeBuilder GaugeArea(Action<RadialGaugeGaugeAreaSettingsBuilder> configurator)
        {

            Container.GaugeArea.RadialGauge = Container;
            configurator(new RadialGaugeGaugeAreaSettingsBuilder(Container.GaugeArea));

            return this;
        }

        /// <summary>
        /// Configures the scale.
        /// </summary>
        /// <param name="configurator">The configurator for the scale setting.</param>
        public RadialGaugeBuilder Scale(Action<RadialGaugeScaleSettingsBuilder> configurator)
        {

            Container.Scale.RadialGauge = Container;
            configurator(new RadialGaugeScaleSettingsBuilder(Container.Scale));

            return this;
        }

        /// <summary>
        /// A value indicating if transition animations should be played.
        /// </summary>
        /// <param name="value">The value for Transitions</param>
        public RadialGaugeBuilder Transitions(bool value)
        {
            Container.Transitions = value;
            return this;
        }


        
    }
}

