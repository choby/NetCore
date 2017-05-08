using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Scale
    /// </summary>
    public partial class RadialGaugeScaleSettingsRangeFactory
        
    {

        public RadialGauge RadialGauge { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual RadialGaugeScaleSettingsRangeBuilder Add()
        {
            var item = new RadialGaugeScaleSettingsRange();
            item.RadialGauge = RadialGauge;
            Container.Add(item);

            return new RadialGaugeScaleSettingsRangeBuilder(item);
        }
    }
}
