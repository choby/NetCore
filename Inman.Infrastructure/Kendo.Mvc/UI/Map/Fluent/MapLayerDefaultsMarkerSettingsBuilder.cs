using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsMarkerSettings
    /// </summary>
    public partial class MapLayerDefaultsMarkerSettingsBuilder
        
    {
        public MapLayerDefaultsMarkerSettingsBuilder(MapLayerDefaultsMarkerSettings container)
        {
            Container = container;
        }

        protected MapLayerDefaultsMarkerSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The marker shape name. The "pin" and "pinTarget" shapes are predefined.
        /// </summary>
        /// <param name="value">The name of the shape.</param>
        public MapLayerDefaultsMarkerSettingsBuilder Shape(string name)
        {
            Container.ShapeName = name;

            return this;
        }

        /// <summary>
        /// Default Kendo UI Tooltip options for this marker.
        /// </summary>
        /// <param name="configurator">The action that configures the tooltip.</param>
        public MapLayerDefaultsMarkerSettingsBuilder Tooltip(Action<MapMarkerTooltipBuilder> configurator)
        {
            configurator(new MapMarkerTooltipBuilder(Container.Tooltip));
            return this;
        }
    }
}
