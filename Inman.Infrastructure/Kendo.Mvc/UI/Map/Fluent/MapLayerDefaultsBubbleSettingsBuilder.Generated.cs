using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBubbleSettings
    /// </summary>
    public partial class MapLayerDefaultsBubbleSettingsBuilder
        
    {
        /// <summary>
        /// The attribution for all bubble layers.
        /// </summary>
        /// <param name="value">The value for Attribution</param>
        public MapLayerDefaultsBubbleSettingsBuilder Attribution(string value)
        {
            Container.Attribution = value;
            return this;
        }

        /// <summary>
        /// The the opacity of all bubble layers.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsBubbleSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The maximum symbol size for bubble layer symbols.
        /// </summary>
        /// <param name="value">The value for MaxSize</param>
        public MapLayerDefaultsBubbleSettingsBuilder MaxSize(double value)
        {
            Container.MaxSize = value;
            return this;
        }

        /// <summary>
        /// The minimum symbol size for bubble layer symbols.
        /// </summary>
        /// <param name="value">The value for MinSize</param>
        public MapLayerDefaultsBubbleSettingsBuilder MinSize(double value)
        {
            Container.MinSize = value;
            return this;
        }

        /// <summary>
        /// The default style for bubble layer symbols.
        /// </summary>
        /// <param name="configurator">The configurator for the style setting.</param>
        public MapLayerDefaultsBubbleSettingsBuilder Style(Action<MapLayerDefaultsBubbleStyleSettingsBuilder> configurator)
        {

            Container.Style.Map = Container.Map;
            configurator(new MapLayerDefaultsBubbleStyleSettingsBuilder(Container.Style));

            return this;
        }

        /// <summary>
        /// The bubble layer symbol type. Supported symbols are "circle" and "square".
        /// </summary>
        /// <param name="value">The value for Symbol</param>
        public MapLayerDefaultsBubbleSettingsBuilder Symbol(MapSymbol value)
        {
            Container.Symbol = value;
            return this;
        }

    }
}
