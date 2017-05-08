using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI AxisDefaults
    /// </summary>
    public partial class ChartAxisDefaultsSettingsPlotBandFactory<T>
        where T : class 
    {

        public Chart<T> Chart { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual ChartAxisDefaultsSettingsPlotBandBuilder<T> Add()
        {
            var item = new ChartAxisDefaultsSettingsPlotBand<T>();
            item.Chart = Chart;
            Container.Add(item);

            return new ChartAxisDefaultsSettingsPlotBandBuilder<T>(item);
        }
    }
}
