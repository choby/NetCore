using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxis
    /// </summary>
    public partial class ChartValueAxisBuilder<T>
        where T : class 
    {
        public ChartValueAxisBuilder(ChartValueAxis<T> container)
        {
            Container = container;
        }

        protected ChartValueAxis<T> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the axis type to date.
        /// </summary>
        public ChartValueAxisBuilder<T> Date()
        {
            Container.Type = "date";
            return this;
        }

        /// <summary>
        /// Sets the axis type to logarithmic.
        /// </summary>
        public ChartValueAxisBuilder<T> Logarithmic()
        {
            Container.Type = "log";
            return this;
        }

        /// <summary>
        /// Sets the axis type to numeric.
        /// </summary>
        public ChartValueAxisBuilder<T> Numeric()
        {
            return Numeric(string.Empty);
        }

        /// <summary>
        /// Defines a numeric value axis.
        /// </summary>
        public virtual ChartValueAxisBuilder<T> Numeric(string name)
        {
            Container.Type = "numeric";
            Container.Name = name;
            return this;
        }

        /// <summary>
        /// Sets the axis type to polar.
        /// </summary>
        public ChartValueAxisBuilder<T> Polar()
        {
            Container.Type = "polar";
            return this;
        }

        /// <summary>
        /// Sets the axis title.
        /// </summary>
        public ChartValueAxisBuilder<T> Title(string value)
        {
            Container.Title.Text = value;

            return this;
        }
    }
}
