using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeries
    /// </summary>
    public partial class ChartSeriesBuilder<T>
        where T : class
    {
        public ChartSeriesBuilder(ChartSeries<T> container)
        {
            Container = container;
        }

        protected ChartSeries<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// The aggregate function to apply for date series.This function is used when a category (an year, month, etc.) contains two or more points.
        /// The function return value is displayed instead of the individual points.The supported values are:
        /// </summary>
        /// <param name="configurator">The configurator for the aggregates setting.</param>
        public ChartSeriesBuilder<T> Aggregate(Action<ChartSeriesAggregateSettingsBuilder<T>> configurator)
        {

            Container.Aggregates.Chart = Container.Chart;
            configurator(new ChartSeriesAggregateSettingsBuilder<T>(Container.Aggregates));

            return this;
        }

        /// <summary>
        /// Specifies the behavior for handling missing values in the series.
        /// </summary>
        /// <param name="value">The value for MissingValues</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> MissingValues(ChartAreaMissingValues value)
        {
            try
            {
                Container.MissingValues = (ChartSeriesMissingValues?)Enum.Parse(typeof(ChartSeriesMissingValues), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the behavior for handling missing values in the series.
        /// </summary>
        /// <param name="value">The value for MissingValues</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> MissingValues(ChartLineMissingValues value)
        {
            try
            {
                Container.MissingValues = (ChartSeriesMissingValues?)Enum.Parse(typeof(ChartSeriesMissingValues), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the behavior for handling missing values in the series.
        /// </summary>
        /// <param name="value">The value for MissingValues</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> MissingValues(ChartScatterLineMissingValues value)
        {
            try
            {
                Container.MissingValues = (ChartSeriesMissingValues?)Enum.Parse(typeof(ChartSeriesMissingValues), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Sets the name of the stack that this series belongs to. Each unique name creates a new stack.
        /// </summary>
        /// <param name="stackType">The stack type.</param>
        /// <param name="stackGroup">The name of the stack group.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart(Model)
        ///             .Name("Chart")
        ///             .Series(series => series.Bar(s => s.Sales).Stack("Female"))
        /// );
        /// </code>
        /// </example>
        public virtual ChartSeriesBuilder<T> Stack(ChartStackType stackType, string stackGroup = null)
        {
            Container.Stack.Type = stackType;

            if (stackGroup != null)
            {
                Container.Stack.Group = stackGroup;
            }

            return this;
        }

        /// <summary>
        /// Sets the name of the stack that this series belongs to. Each unique name creates a new stack.
        /// </summary>
        /// <param name="stackGroup">The name of the stack group.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart(Model)
        ///             .Name("Chart")
        ///             .Series(series => series.Bar(s => s.Sales).Stack("Female"))
        /// );
        /// </code>
        /// </example>
        public virtual ChartSeriesBuilder<T> Stack(string stackGroup)
        {
            Container.Stack.Group = stackGroup;

            return this;
        }
        
        /// <summary>
        /// Specifies the preferred rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> Style(ChartLineStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesStyle?)Enum.Parse(typeof(ChartSeriesStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the preferred rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> Style(ChartPolarLineStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesStyle?)Enum.Parse(typeof(ChartSeriesStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the preferred rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> Style(ChartRadarLineStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesStyle?)Enum.Parse(typeof(ChartSeriesStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }

        /// <summary>
        /// Specifies the preferred rendering style.
        /// </summary>
        /// <param name="value">The value for Style</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ChartSeriesBuilder<T> Style(ChartScatterLineStyle value)
        {
            try
            {
                Container.Style = (ChartSeriesStyle?)Enum.Parse(typeof(ChartSeriesStyle), value.ToString());
            }
            catch (Exception)
            {
            }

            return this;
        }
    }
}
