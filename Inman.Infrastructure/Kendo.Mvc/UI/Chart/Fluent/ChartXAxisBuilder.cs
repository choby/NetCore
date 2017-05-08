using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxis
    /// </summary>
    public partial class ChartXAxisBuilder<T>
        where T : class 
    {
        public ChartXAxisBuilder(ChartXAxis<T> container)
        {
            Container = container;
        }

        protected ChartXAxis<T> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the axis type to date.
        /// </summary>
        public ChartXAxisBuilder<T> Date()
        {
            Container.Type = "date";
            return this;
        }

        /// <summary>
        /// Sets the axis type to logarithmic.
        /// </summary>
        public ChartXAxisBuilder<T> Logarithmic()
        {
            Container.Type = "log";
            return this;
        }

        /// <summary>
        /// Sets the axis type to numeric.
        /// </summary>
        public ChartXAxisBuilder<T> Numeric()
        {
            Container.Type = "numeric";
            return this;
        }

        /// <summary>
        /// Sets the axis type to polar.
        /// </summary>
        public ChartXAxisBuilder<T> Polar()
        {
            Container.Type = "polar";
            return this;
        }

        /// <summary>
        /// Sets the axis title.
        /// </summary>
        /// </example>
        public ChartXAxisBuilder<T> Title(string value)
        {
            Container.Title.Text = value;

            return this;
        }
    }
}
