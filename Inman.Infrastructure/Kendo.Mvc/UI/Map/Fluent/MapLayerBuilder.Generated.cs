using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayer
    /// </summary>
    public partial class MapLayerBuilder
        
    {
        /// <summary>
        /// The attribution for the layer. Accepts valid HTML.
        /// </summary>
        /// <param name="value">The value for Attribution</param>
        public MapLayerBuilder Attribution(string value)
        {
            Container.Attribution = value;
            return this;
        }

        /// <summary>
        /// If set to false the layer will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public MapLayerBuilder AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// Specifies the extent of the region covered by this layer.
		/// The layer will be hidden when the specified area is out of view.Accepts a four-element array that specifies the extent covered by this layer:
		/// North-West lat, longitude, South-East latitude, longitude.If not specified, the layer is always visible.
        /// </summary>
        /// <param name="value">The value for Extent</param>
        public MapLayerBuilder Extent(params double[] value)
        {
            Container.Extent = value;
            return this;
        }

        /// <summary>
        /// The API key for the layer. Currently supported only for Bing (tm) tile layers.
        /// </summary>
        /// <param name="value">The value for Key</param>
        public MapLayerBuilder Key(string value)
        {
            Container.Key = value;
            return this;
        }

        /// <summary>
        /// The culture to be used for the bing map tiles.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public MapLayerBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the marker (symbol) location.
		/// The field should be an array with two numbers - latitude and longitude in decimal degrees.Requires the dataSource option to be set.Only applicable to "marker" and "bubble" layers.
        /// </summary>
        /// <param name="value">The value for LocationField</param>
        public MapLayerBuilder LocationField(string value)
        {
            Container.LocationField = value;
            return this;
        }

        /// <summary>
        /// The size of the image tile in pixels.
        /// </summary>
        /// <param name="value">The value for TileSize</param>
        public MapLayerBuilder TileSize(double value)
        {
            Container.TileSize = value;
            return this;
        }

        /// <summary>
        /// The data item field which contains the marker title.
		/// Requires the dataSource option to be set.
        /// </summary>
        /// <param name="value">The value for TitleField</param>
        public MapLayerBuilder TitleField(string value)
        {
            Container.TitleField = value;
            return this;
        }

        /// <summary>
        /// The maximum symbol size for bubble layer symbols.
        /// </summary>
        /// <param name="value">The value for MaxSize</param>
        public MapLayerBuilder MaxSize(double value)
        {
            Container.MaxSize = value;
            return this;
        }

        /// <summary>
        /// The minimum symbol size for bubble layer symbols.
        /// </summary>
        /// <param name="value">The value for MinSize</param>
        public MapLayerBuilder MinSize(double value)
        {
            Container.MinSize = value;
            return this;
        }

        /// <summary>
        /// The the opacity for the layer.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public MapLayerBuilder Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// A list of subdomains to use for loading tiles.
		/// Alternating between different subdomains allows more requests to be executed in parallel.
        /// </summary>
        /// <param name="value">The value for Subdomains</param>
        public MapLayerBuilder Subdomains(params string[] value)
        {
            Container.Subdomains = value;
            return this;
        }

        /// <summary>
        /// The default style for shapes.
        /// </summary>
        /// <param name="configurator">The configurator for the style setting.</param>
        public MapLayerBuilder Style(Action<MapLayerStyleSettingsBuilder> configurator)
        {

            Container.Style.Map = Container.Map;
            configurator(new MapLayerStyleSettingsBuilder(Container.Style));

            return this;
        }

        /// <summary>
        /// The URL template for tile layers. Template variables:
        /// </summary>
        /// <param name="value">The value for UrlTemplate</param>
        public MapLayerBuilder UrlTemplate(string value)
        {
            Container.UrlTemplate = value;
            return this;
        }

        /// <summary>
        /// The URL template for tile layers. Template variables:
        /// </summary>
        /// <param name="value">The ID of the template element for UrlTemplate</param>
        public MapLayerBuilder UrlTemplateId(string templateId)
        {
            Container.UrlTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The value field for bubble layer symbols.
		/// The data item field should be a number.
        /// </summary>
        /// <param name="value">The value for ValueField</param>
        public MapLayerBuilder ValueField(string value)
        {
            Container.ValueField = value;
            return this;
        }

        /// <summary>
        /// The zIndex for this layer.Layers are normally stacked in declaration order (last one is on top).
        /// </summary>
        /// <param name="value">The value for ZIndex</param>
        public MapLayerBuilder ZIndex(double value)
        {
            Container.ZIndex = value;
            return this;
        }

        /// <summary>
        /// The layer type. Supported types are "tile", "bing", "shape", "marker" and "bubble".
        /// </summary>
        /// <param name="value">The value for Type</param>
        public MapLayerBuilder Type(MapLayerType value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// The bing map tile types. Possible options.
        /// </summary>
        /// <param name="value">The value for ImagerySet</param>
        public MapLayerBuilder ImagerySet(MapLayersImagerySet value)
        {
            Container.ImagerySet = value;
            return this;
        }

        /// <summary>
        /// The marker shape. Supported shapes are "pin" and "pinTarget".
        /// </summary>
        /// <param name="value">The value for Shape</param>
        public MapLayerBuilder Shape(MapMarkersShape value)
        {
            Container.Shape = value;
            return this;
        }

        /// <summary>
        /// The bubble layer symbol type. Supported symbols are "circle" and "square".
        /// </summary>
        /// <param name="value">The value for Symbol</param>
        public MapLayerBuilder Symbol(MapSymbol value)
        {
            Container.Symbol = value;
            return this;
        }

    }
}
