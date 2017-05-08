using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsSettings
    /// </summary>
    public partial class ChartSeriesLabelsSettingsBuilder<T>
        where T : class
    {
        public ChartSeriesLabelsSettingsBuilder(ChartSeriesLabelsSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// Specifies the alignment of the labels.
        /// </summary>
        /// <param name="value">The value for Align</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLabelsSettingsBuilder<T> Align(ChartFunnelLabelsAlign value)
        {
            try
            {
                Container.Align = (ChartSeriesLabelsAlign?) Enum.Parse(typeof(ChartSeriesLabelsAlign), value.ToString());
            }
            catch (Exception)
            {
            }
            return this;
        }

        /// <summary>
        /// Specifies the alignment of the labels.
        /// </summary>
        /// <param name="value">The value for Align</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLabelsSettingsBuilder<T> Align(ChartPieLabelsAlign value)
        {
            try
            {
                Container.Align = (ChartSeriesLabelsAlign?) Enum.Parse(typeof(ChartSeriesLabelsAlign), value.ToString());
            }
            catch (Exception)
            {
            }
            return this;
        }

        /// <summary>
        /// The margin of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Margin(int value)
        {
            Container.Margin.Top = value;
            Container.Margin.Right = value;
            Container.Margin.Bottom = value;
            Container.Margin.Left = value;

            return this;
        }

        /// <summary>
        /// The margin of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Padding(int value)
        {
            Container.Padding.Top = value;
            Container.Padding.Right = value;
            Container.Padding.Bottom = value;
            Container.Padding.Left = value;

            return this;
        }

        /// <summary>
        /// Specifies the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLabelsSettingsBuilder<T> Position(ChartBarLabelsPosition value)
        {
            try
            {
                Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof(ChartSeriesLabelsPosition), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLabelsSettingsBuilder<T> Position(ChartFunnelLabelsPosition value)
        {
            try
            {
                Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof(ChartSeriesLabelsPosition), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLabelsSettingsBuilder<T> Position(ChartPieLabelsPosition value)
        {
            try
            {
                Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof(ChartSeriesLabelsPosition), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesLabelsSettingsBuilder<T> Position(ChartPointLabelsPosition value)
        {
            try
            {
                Container.Position = (ChartSeriesLabelsPosition?) Enum.Parse(typeof(ChartSeriesLabelsPosition), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }
    }
}
