using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBingSettings
    /// </summary>
    public partial class MapLayerDefaultsBingSettingsBuilder
        
    {
        /// <summary>
        /// The attribution of all Bing (tm) layers.
        /// </summary>
        /// <param name="value">The value for Attribution</param>
        public MapLayerDefaultsBingSettingsBuilder Attribution(string value)
        {
            Container.Attribution = value;
            return this;
        }

        /// <summary>
        /// The the opacity of all Bing (tm) tile layers.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsBingSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The key of all Bing (tm) tile layers.
        /// </summary>
        /// <param name="value">The value for Key</param>
        public MapLayerDefaultsBingSettingsBuilder Key(string value)
        {
            Container.Key = value;
            return this;
        }

        /// <summary>
        /// The culture to be used for the bing map tiles.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public MapLayerDefaultsBingSettingsBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// The bing map tile types. Possible options.
        /// </summary>
        /// <param name="value">The value for ImagerySet</param>
        public MapLayerDefaultsBingSettingsBuilder ImagerySet(MapLayersImagerySet value)
        {
            Container.ImagerySet = value;
            return this;
        }

    }
}
