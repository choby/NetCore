using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartPane<T>>
    /// </summary>
    public partial class ChartPaneFactory<T>
        where T : class 
    {
        public ChartPaneFactory(List<ChartPane<T>> container)
        {
            Container = container;
        }

        protected List<ChartPane<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// Defines a named chart pane.
        /// </summary>
        /// <param name="name">
        /// The unique pane name
        /// </param>
        public virtual ChartPaneBuilder<T> Add(string name)
        {
            var item = new ChartPane<T>();
            item.Name = name;
            Container.Add(item);

            return new ChartPaneBuilder<T>(item);
        }
    }
}
