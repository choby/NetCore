using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<LinearGaugePointer>
    /// </summary>
    public partial class LinearGaugePointerFactory
        
    {
        public LinearGauge LinearGauge { get; set; }

        public LinearGaugePointerFactory(List<LinearGaugePointer> container)
        {
            Container = container;
        }

        protected List<LinearGaugePointer> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual LinearGaugePointerBuilder Add()
        {
            var item = new LinearGaugePointer();
            item.LinearGauge = LinearGauge;
            Container.Add(item);

            return new LinearGaugePointerBuilder(item);
        }
    }
}
