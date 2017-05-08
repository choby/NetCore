using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<LinearGaugeScaleSettingsRange>
    /// </summary>
    public partial class LinearGaugeScaleSettingsRangeFactory
        
    {
        public LinearGaugeScaleSettingsRangeFactory(List<LinearGaugeScaleSettingsRange> container)
        {
            Container = container;
        }

        protected List<LinearGaugeScaleSettingsRange> Container
        {
            get;
            private set;
        }

        public virtual LinearGaugeScaleSettingsRangeBuilder Add(double from, double to, string color)
        {
            var item = new LinearGaugeScaleSettingsRange();
            item.LinearGauge = LinearGauge;
            item.From = from;
            item.To = to;
            item.Color = color;

            Container.Add(item);

            return new LinearGaugeScaleSettingsRangeBuilder(item);
        }
    }
}
