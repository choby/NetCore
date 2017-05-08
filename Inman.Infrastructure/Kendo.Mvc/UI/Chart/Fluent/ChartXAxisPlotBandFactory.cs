using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartXAxisPlotBand<T>>
    /// </summary>
    public partial class ChartXAxisPlotBandFactory<T>
        where T : class 
    {
        public ChartXAxisPlotBandFactory(List<ChartXAxisPlotBand<T>> container)
        {
            Container = container;
        }

        protected List<ChartXAxisPlotBand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
                
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartXAxisPlotBandBuilder<T> Add(double from, double to, string color)
        {
            var item = new ChartXAxisPlotBand<T>()
            {
                Chart = Chart,
                From = from,
                To = to,
                Color = color
            };
            Container.Add(item);            

            return new ChartXAxisPlotBandBuilder<T>(item);
        }
    }
}
