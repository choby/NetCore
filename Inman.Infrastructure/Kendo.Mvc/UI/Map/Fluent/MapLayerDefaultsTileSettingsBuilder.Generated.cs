using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsTileSettings
    /// </summary>
    public partial class MapLayerDefaultsTileSettingsBuilder
        
    {
        /// <summary>
        /// The URL template for tile layers. Template variables:
        /// </summary>
        /// <param name="value">The value for UrlTemplate</param>
        public MapLayerDefaultsTileSettingsBuilder UrlTemplate(string value)
        {
            Container.UrlTemplate = value;
            return this;
        }

        /// <summary>
        /// The URL template for tile layers. Template variables:
        /// </summary>
        /// <param name="value">The ID of the template element for UrlTemplate</param>
        public MapLayerDefaultsTileSettingsBuilder UrlTemplateId(string templateId)
        {
            Container.UrlTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The attribution of all tile layers.
        /// </summary>
        /// <param name="value">The value for Attribution</param>
        public MapLayerDefaultsTileSettingsBuilder Attribution(string value)
        {
            Container.Attribution = value;
            return this;
        }

        /// <summary>
        /// The subdomain of all tile layers.
        /// </summary>
        /// <param name="value">The value for Subdomains</param>
        public MapLayerDefaultsTileSettingsBuilder Subdomains(params string[] value)
        {
            Container.Subdomains = value;
            return this;
        }

        /// <summary>
        /// The the opacity of all tile layers.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerDefaultsTileSettingsBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

    }
}
