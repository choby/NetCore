using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<RadialGaugeScaleSettingsRange>
    /// </summary>
    public partial class RadialGaugeScaleSettingsRangeFactory
        
    {
        public RadialGaugeScaleSettingsRangeFactory(List<RadialGaugeScaleSettingsRange> container)
        {
            Container = container;
        }

        protected List<RadialGaugeScaleSettingsRange> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Defines a item.
        /// </summary>
        public virtual RadialGaugeScaleSettingsRangeBuilder Add(double from, double to, string color)
        {
            var item = new RadialGaugeScaleSettingsRange();
            item.RadialGauge = RadialGauge;
            item.From = from;
            item.To = to;
            item.Color = color;

            Container.Add(item);

            return new RadialGaugeScaleSettingsRangeBuilder(item);
        }
    }
}
