using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPane
    /// </summary>
    public partial class ChartPaneBuilder<T>
        where T : class 
    {
        public ChartPaneBuilder(ChartPane<T> container)
        {
            Container = container;
        }

        protected ChartPane<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// The title configuration of the chart pane.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public ChartPaneBuilder<T> Title(string value)
        {
            Container.Title.Text = value;
            Container.Title.Chart = Container.Chart;

            return this;
        }
    }
}
