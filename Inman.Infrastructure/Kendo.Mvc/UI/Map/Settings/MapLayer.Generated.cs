using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayer class
    /// </summary>
    public partial class MapLayer 
    {
        public string Attribution { get; set; }

        public bool? AutoBind { get; set; }

        public double[] Extent { get; set; }

        public string Key { get; set; }

        public string Culture { get; set; }

        public string LocationField { get; set; }

        public double? TileSize { get; set; }

        public string TitleField { get; set; }

        public double? MaxSize { get; set; }

        public double? MinSize { get; set; }

        public double? Opacity { get; set; }

        public string[] Subdomains { get; set; }

        public MapLayerStyleSettings Style { get; } = new MapLayerStyleSettings();

        public string UrlTemplate { get; set; }

        public string UrlTemplateId { get; set; }

        public string ValueField { get; set; }

        public double? ZIndex { get; set; }

        public MapLayerType? Type { get; set; }

        public MapLayersImagerySet? ImagerySet { get; set; }

        public MapMarkersShape? Shape { get; set; }

        public MapSymbol? Symbol { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Attribution?.HasValue() == true)
            {
                settings["attribution"] = Attribution;
            }

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (Extent?.Any() == true)
            {
                settings["extent"] = Extent;
            }

            if (Key?.HasValue() == true)
            {
                settings["key"] = Key;
            }

            if (Culture?.HasValue() == true)
            {
                settings["culture"] = Culture;
            }

            if (LocationField?.HasValue() == true)
            {
                settings["locationField"] = LocationField;
            }

            if (TileSize.HasValue)
            {
                settings["tileSize"] = TileSize;
            }

            if (TitleField?.HasValue() == true)
            {
                settings["titleField"] = TitleField;
            }

            if (MaxSize.HasValue)
            {
                settings["maxSize"] = MaxSize;
            }

            if (MinSize.HasValue)
            {
                settings["minSize"] = MinSize;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Subdomains?.Any() == true)
            {
                settings["subdomains"] = Subdomains;
            }

            var style = Style.Serialize();
            if (style.Any())
            {
                settings["style"] = style;
            }

            if (UrlTemplateId.HasValue())
            {
                settings["urlTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Map.IdPrefix, UrlTemplateId
                    )
                };
            }
            else if (UrlTemplate.HasValue())
            {
                settings["urlTemplate"] = UrlTemplate;
            }

            if (ValueField?.HasValue() == true)
            {
                settings["valueField"] = ValueField;
            }

            if (ZIndex.HasValue)
            {
                settings["zIndex"] = ZIndex;
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            if (ImagerySet.HasValue)
            {
                settings["imagerySet"] = ImagerySet?.Serialize();
            }

            if (Symbol.HasValue)
            {
                settings["symbol"] = Symbol?.Serialize();
            }

            return settings;
        }
    }
}
