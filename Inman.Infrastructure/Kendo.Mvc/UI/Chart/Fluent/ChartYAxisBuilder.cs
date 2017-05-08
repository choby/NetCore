using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxis
    /// </summary>
    public partial class ChartYAxisBuilder<T>
        where T : class 
    {
        public ChartYAxisBuilder(ChartYAxis<T> container)
        {
            Container = container;
        }

        protected ChartYAxis<T> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the axis type to date.
        /// </summary>
        public ChartYAxisBuilder<T> Date()
        {
            Container.Type = "date";
            return this;
        }

        /// <summary>
        /// Sets the axis type to logarithmic.
        /// </summary>
        public ChartYAxisBuilder<T> Logarithmic()
        {
            Container.Type = "log";
            return this;
        }

        /// <summary>
        /// Sets the axis type to numeric.
        /// </summary>
        public ChartYAxisBuilder<T> Numeric()
        {
            return Numeric(string.Empty);
        }

        /// <summary>
        /// Defines a numeric axis.
        /// </summary>
        public ChartYAxisBuilder<T> Numeric(string name)
        {
            Container.Type = "numeric";
            Container.Name = name;
            return this;
        }

        /// <summary>
        /// Sets the axis type to polar.
        /// </summary>
        public ChartYAxisBuilder<T> Polar()
        {
            Container.Type = "polar";
            return this;
        }

        /// <summary>
        /// Sets the axis title.
        /// </summary>
        /// </example>
        public ChartYAxisBuilder<T> Title(string value)
        {
            Container.Title.Text = value;

            return this;
        }
    }
}
