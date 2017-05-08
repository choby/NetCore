using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapMarker
    /// </summary>
    public partial class MapMarkerBuilder
        
    {
        public MapMarkerBuilder(MapMarker container)
        {
            Container = container;
        }

        protected MapMarker Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the HTML attributes.
        /// </summary>
        /// <param name="attributes">The HTML attributes.</param>
        /// <returns></returns>
        public virtual MapMarkerBuilder HtmlAttributes(object attributes)
        {
            return HtmlAttributes(attributes.ToDictionary());
        }

        /// <summary>
        /// Sets the HTML attributes.
        /// </summary>
        /// <param name="attributes">The HTML attributes.</param>
        /// <returns></returns>
        public virtual MapMarkerBuilder HtmlAttributes(IDictionary<string, object> attributes)
        {
            Container.HtmlAttributes.Clear();
            Container.HtmlAttributes.Merge(attributes);

            return this;
        }

        /// <summary>
        /// The marker shape name. The "pin" and "pinTarget" shapes are predefined.
        /// </summary>
        /// <param name="value">The name of the shape.</param>
        public MapMarkerBuilder Shape(string name)
        {
            Container.ShapeName = name;

            return this;
        }

        /// <summary>
        /// The tooltip options for this marker.
        /// </summary>
        /// <param name="configurator">The action that configures the tooltip.</param>
        public MapMarkerBuilder Tooltip(Action<MapMarkerTooltipBuilder> configurator)
        {
            configurator(new MapMarkerTooltipBuilder(Container.Tooltip));
            return this;
        }
    }
}
