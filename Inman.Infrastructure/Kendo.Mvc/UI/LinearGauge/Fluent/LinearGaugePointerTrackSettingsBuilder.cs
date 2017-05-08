using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugePointerTrackSettings
    /// </summary>
    public partial class LinearGaugePointerTrackSettingsBuilder
        
    {
        public LinearGaugePointerTrackSettingsBuilder(LinearGaugePointerTrackSettings container)
        {
            Container = container;
        }

        protected LinearGaugePointerTrackSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The border of the track.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public LinearGaugePointerTrackSettingsBuilder Border(Action<LinearGaugePointerTrackBorderSettingsBuilder> configurator)
        {

            Container.Border.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugePointerTrackBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// Sets the track border.
        /// </summary>
        /// <param name="width">The pointer border width.</param>
        /// <param name="color">The pointer border color.</param>
        /// <param name="dashType">The pointer dash type.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().LinearGauge()
        ///           .Name("linearGauge")
        ///           .Pointer(pointer => pointer
        ///               .Track(track => track.Border(1, "#000", ChartDashType.Dot))
        ///           )         
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public LinearGaugePointerTrackSettingsBuilder Border(int width, string color, ChartDashType dashType)
        {
            Container.Border.Width = width;
            Container.Border.Color = color;
            Container.Border.DashType = dashType;

            return this;
        }

        /// <summary>
        /// The color of the track.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugePointerTrackSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The opacity of the track.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public LinearGaugePointerTrackSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The size of the track.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public LinearGaugePointerTrackSettingsBuilder Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The visibility of the track.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public LinearGaugePointerTrackSettingsBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The visibility of the track.
        /// </summary>
        public LinearGaugePointerTrackSettingsBuilder Visible()
        {
            Container.Visible = true;
            return this;
        }
    }
}
