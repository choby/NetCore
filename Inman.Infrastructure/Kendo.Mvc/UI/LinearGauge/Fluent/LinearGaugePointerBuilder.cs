using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugePointer
    /// </summary>
    public partial class LinearGaugePointerBuilder
        
    {
        public LinearGaugePointerBuilder(LinearGaugePointer container)
        {
            Container = container;
        }

        protected LinearGaugePointer Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The border of the pointer.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public LinearGaugePointerBuilder Border(Action<LinearGaugePointerBorderSettingsBuilder> configurator)
        {

            Container.Border.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugePointerBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// Sets the pointer border
        /// </summary>
        /// <param name="width">The pointer border width.</param>
        /// <param name="color">The pointer border color.</param>
        /// <param name="dashType">The pointer dash type.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().LinearGauge()
        ///           .Name("linearGauge")
        ///           .Pointer(pointer => pointer
        ///               .Border(1, "#000", ChartDashType.Dot)
        ///           )
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>        
        public LinearGaugePointerBuilder Border(int width, string color, ChartDashType dashType)
        {
            Container.Border.LinearGauge = Container.LinearGauge;

            Container.Border.Width = width;
            Container.Border.Color = color;
            Container.Border.DashType = dashType;

            return this;
        }

        /// <summary>
        /// The color of the pointer.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugePointerBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The margin of the pointer.
        /// </summary>
        /// <param name="value">The value for Margin</param>
        public LinearGaugePointerBuilder Margin(double value)
        {
            Container.Margin.All(value);
            return this;
        }

        /// <summary>
        /// Sets the pointer margin.
        /// </summary>
        /// <param name="top">The pointer top margin.</param>
        /// <param name="right">The pointer right margin.</param>
        /// <param name="bottom">The pointer bottom margin.</param>
        /// <param name="left">The pointer left margin.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().LinearGauge()
        ///           .Name("linearGauge")
        ///           .Pointer(pointer => pointer
        ///               .Margin(20, 20, 20, 20)
        ///           )
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>   
        public LinearGaugePointerBuilder Margin(double top, double right, double bottom, double left)
        {
            Container.Margin.Top = top;
            Container.Margin.Right = right;
            Container.Margin.Bottom = bottom;
            Container.Margin.Left = left;
            return this;
        }

        /// <summary>
        /// The opacity of the pointer.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public LinearGaugePointerBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The shape of the pointer.
        /// </summary>
        /// <param name="value">The value for Shape</param>
        public LinearGaugePointerBuilder Shape(GaugeLinearPointerShape value)
        {
            Container.Shape = value;
            return this;
        }

        /// <summary>
        /// The size of the pointer.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public LinearGaugePointerBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The element arround/under the pointer.
		/// (available only for 'barIndicator' shape)
        /// </summary>
        /// <param name="configurator">The configurator for the track setting.</param>
        public LinearGaugePointerBuilder Track(Action<LinearGaugePointerTrackSettingsBuilder> configurator)
        {

            Container.Track.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugePointerTrackSettingsBuilder(Container.Track));

            return this;
        }

        /// <summary>
        /// The value of the gauge.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public LinearGaugePointerBuilder Value(double value)
        {
            Container.Value = value;
            return this;
        }
    }
}
