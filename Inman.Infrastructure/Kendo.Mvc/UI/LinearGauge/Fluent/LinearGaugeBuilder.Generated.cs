using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI LinearGauge
    /// </summary>
    public partial class LinearGaugeBuilder
        
    {
        /// <summary>
        /// The gauge area configuration options.
		/// This is the entire visible area of the gauge.
        /// </summary>
        /// <param name="configurator">The configurator for the gaugearea setting.</param>
        public LinearGaugeBuilder GaugeArea(Action<LinearGaugeGaugeAreaSettingsBuilder> configurator)
        {

            Container.GaugeArea.LinearGauge = Container;
            configurator(new LinearGaugeGaugeAreaSettingsBuilder(Container.GaugeArea));

            return this;
        }

        /// <summary>
        /// Sets the preferred rendering engine.
		/// If it is not supported by the browser, the Gauge will switch to the first available mode.The supported values are:
        /// </summary>
        /// <param name="value">The value for RenderAs</param>
        public LinearGaugeBuilder RenderAs(RenderingMode value)
        {
            Container.RenderAs = value;
            return this;
        }

        /// <summary>
        /// Configures the scale.
        /// </summary>
        /// <param name="configurator">The configurator for the scale setting.</param>
        public LinearGaugeBuilder Scale(Action<LinearGaugeScaleSettingsBuilder> configurator)
        {

            Container.Scale.LinearGauge = Container;
            configurator(new LinearGaugeScaleSettingsBuilder(Container.Scale));

            return this;
        }

        /// <summary>
        /// A value indicating if transition animations should be played.
        /// </summary>
        /// <param name="value">The value for Transitions</param>
        public LinearGaugeBuilder Transitions(bool value)
        {
            Container.Transitions = value;
            return this;
        }


        
    }
}

