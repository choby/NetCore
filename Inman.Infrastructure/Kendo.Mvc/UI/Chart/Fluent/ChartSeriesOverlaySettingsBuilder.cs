using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesOverlaySettings
    /// </summary>
    public partial class ChartSeriesOverlaySettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesOverlaySettingsBuilder(ChartSeriesOverlaySettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesOverlaySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// Specifies the series gradient.
        /// </summary>
        /// <param name="value">The value for Gradient</param>
        [Obsolete("The property is deprecated. Please use the ChartSeriesGradient value instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesOverlaySettingsBuilder<T> Gradient(ChartBarGradient value)
        {
            try
            {
                Container.Gradient = (ChartSeriesGradient?)Enum.Parse(typeof(ChartSeriesGradient), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }
    }
}
