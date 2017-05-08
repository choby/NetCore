using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugePointerBorderSettings
    /// </summary>
    public partial class LinearGaugePointerBorderSettingsBuilder
        
    {
        public LinearGaugePointerBorderSettingsBuilder(LinearGaugePointerBorderSettings container)
        {
            Container = container;
        }

        protected LinearGaugePointerBorderSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The color of the border.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugePointerBorderSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the border.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public LinearGaugePointerBorderSettingsBuilder DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public LinearGaugePointerBorderSettingsBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The opacity of the border.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public LinearGaugePointerBorderSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }
    }
}
