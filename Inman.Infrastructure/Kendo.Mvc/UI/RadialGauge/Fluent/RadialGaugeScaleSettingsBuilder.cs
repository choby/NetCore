using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleSettings
    /// </summary>
    public partial class RadialGaugeScaleSettingsBuilder
        
    {
        public RadialGaugeScaleSettingsBuilder(RadialGaugeScaleSettings container)
        {
            Container = container;
        }

        protected RadialGaugeScaleSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Configures the major ticks.
        /// </summary>
        /// <param name="configurator">The configuration action.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().LinearGauge()
        ///            .Name("linearGauge")
        ///            .Scale(scale => scale
        ///                .Line(line => line
        ///                    .Visible(false)
        ///                )
        ///            )
        /// %&gt;
        /// </code>
        /// </example>
        //public TScaleBuilder Line(Action<GaugeLineBuilder> configurator)
        //{
        //    configurator(new GaugeLineBuilder(Scale.Line));

        //    return this as TScaleBuilder;
        //}
    }
}
