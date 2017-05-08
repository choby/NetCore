using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI LinearGauge
    /// </summary>
    public partial class LinearGaugeBuilder: WidgetBuilderBase<LinearGauge, LinearGaugeBuilder>
        
    {
        public LinearGaugeBuilder(LinearGauge component) : base(component)
        {
        }

        /// <summary>
        /// Sets the theme of the linear gauge.
        /// </summary>
        /// <param name="theme">The linear gauge theme.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().RadialGauge()
        ///            .Name("radialGauge")
        ///            .Theme("Black")
        /// %&gt;
        /// </code>
        /// </example>
        public LinearGaugeBuilder Theme(string theme)
        {
            Component.Theme = theme;
            return this;
        }

        /// <summary>
        /// The pointer configuration options. It accepts an Array of pointers, each with it's own configuration options.
        /// </summary>
        /// <param name="configurator">The configurator for the pointer setting.</param>
        public LinearGaugeBuilder Pointers(Action<LinearGaugePointerFactory> configurator)
        {

            configurator(new LinearGaugePointerFactory(Container.Pointers)
            {
                LinearGauge = Container
            });

            return this;
        }

        /// <summary>
        /// Configures the pointer
        /// </summary>
        /// <param name="configurator">The configurator</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().LinearGauge()
        ///            .Name("linearGauge")
        ///            .Pointer(pointer => pointer
        ///                .Value(10)
        ///            )
        /// %&gt;
        /// </code>
        /// </example>
        public LinearGaugeBuilder Pointer(Action<LinearGaugePointerBuilder> configurator)
        {
            configurator(new LinearGaugePointerBuilder(Container.Pointer));

            return this;
        }
    }
}

