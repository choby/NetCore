using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapMarkerDefaultsSettings
    /// </summary>
    public partial class MapMarkerDefaultsSettingsBuilder
        
    {
        public MapMarkerDefaultsSettingsBuilder(MapMarkerDefaultsSettings container)
        {
            Container = container;
        }

        protected MapMarkerDefaultsSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The marker shape name. The "pin" and "pinTarget" shapes are predefined.
        /// </summary>
        /// <param name="value">The name of the shape.</param>
        public MapMarkerDefaultsSettingsBuilder Shape(string name)
        {
            Container.ShapeName = name;

            return this;
        }

        /// <summary>
        /// Default Kendo UI Tooltip options for this marker.
        /// </summary>
        /// <param name="configurator">The action that configures the tooltip.</param>
        public MapMarkerDefaultsSettingsBuilder Tooltip(Action<MapMarkerTooltipBuilder> configurator)
        {
            configurator(new MapMarkerTooltipBuilder(Container.Tooltip));
            return this;
        }
    }
}
