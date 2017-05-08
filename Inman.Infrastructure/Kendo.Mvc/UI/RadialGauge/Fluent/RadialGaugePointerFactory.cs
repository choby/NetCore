using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<RadialGaugePointer>
    /// </summary>
    public partial class RadialGaugePointerFactory
    {
        public RadialGauge RadialGauge { get; set; }

        public RadialGaugePointerFactory(List<RadialGaugePointer> container)
        {
            Container = container;
        }

        protected List<RadialGaugePointer> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual RadialGaugePointerBuilder Add()
        {
            var item = new RadialGaugePointer();
            item.RadialGauge = RadialGauge;
            Container.Add(item);

            return new RadialGaugePointerBuilder(item);
        }
    }
}
