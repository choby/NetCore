using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugePointerTrackBorderSettings
    /// </summary>
    public partial class LinearGaugePointerTrackBorderSettingsBuilder
        
    {
        public LinearGaugePointerTrackBorderSettingsBuilder(LinearGaugePointerTrackBorderSettings container)
        {
            Container = container;
        }

        protected LinearGaugePointerTrackBorderSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The color of the border. Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugePointerTrackBorderSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the border.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public LinearGaugePointerTrackBorderSettingsBuilder DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public LinearGaugePointerTrackBorderSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The opacity of the border.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public LinearGaugePointerTrackBorderSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }
    }
}
