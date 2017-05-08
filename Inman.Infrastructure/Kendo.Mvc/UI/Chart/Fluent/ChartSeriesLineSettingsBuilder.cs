using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLineSettings
    /// </summary>
    public partial class ChartSeriesLineSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLineSettingsBuilder(ChartSeriesLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        // <summary>
        /// Specifies the preferred line rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [Obsolete("The property is deprecated. Please use the ChartSeriesLineStyle value instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLineSettingsBuilder<T> Style(ChartAreaStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesLineStyle?)Enum.Parse(typeof(ChartSeriesLineStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        // <summary>
        /// Specifies the preferred line rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [Obsolete("The property is deprecated. Please use the ChartSeriesLineStyle value instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLineSettingsBuilder<T> Style(ChartPolarAreaStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesLineStyle?)Enum.Parse(typeof(ChartSeriesLineStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        // <summary>
        /// Specifies the preferred line rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [Obsolete("The property is deprecated. Please use the ChartSeriesLineStyle value instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLineSettingsBuilder<T> Style(ChartRadarAreaStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesLineStyle?)Enum.Parse(typeof(ChartSeriesLineStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }
    }
}
