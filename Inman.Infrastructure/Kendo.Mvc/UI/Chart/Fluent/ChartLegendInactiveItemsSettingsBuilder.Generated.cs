using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendInactiveItemsSettings
    /// </summary>
    public partial class ChartLegendInactiveItemsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The chart legend label configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public ChartLegendInactiveItemsSettingsBuilder<T> Labels(Action<ChartLegendInactiveItemsLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.Chart = Container.Chart;
            configurator(new ChartLegendInactiveItemsLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

    }
}
