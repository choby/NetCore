using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Scale
    /// </summary>
    public partial class LinearGaugeScaleSettingsRangeFactory
        
    {

        public LinearGauge LinearGauge { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual LinearGaugeScaleSettingsRangeBuilder Add()
        {
            var item = new LinearGaugeScaleSettingsRange();
            item.LinearGauge = LinearGauge;
            Container.Add(item);

            return new LinearGaugeScaleSettingsRangeBuilder(item);
        }
    }
}
