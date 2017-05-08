using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsBubbleSettings class
    /// </summary>
    public partial class MapLayerDefaultsBubbleSettings 
    {
        public string Attribution { get; set; }

        public double? Opacity { get; set; }

        public double? MaxSize { get; set; }

        public double? MinSize { get; set; }

        public MapLayerDefaultsBubbleStyleSettings Style { get; } = new MapLayerDefaultsBubbleStyleSettings();

        public MapSymbol? Symbol { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Attribution?.HasValue() == true)
            {
                settings["attribution"] = Attribution;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (MaxSize.HasValue)
            {
                settings["maxSize"] = MaxSize;
            }

            if (MinSize.HasValue)
            {
                settings["minSize"] = MinSize;
            }

            var style = Style.Serialize();
            if (style.Any())
            {
                settings["style"] = style;
            }

            if (Symbol.HasValue)
            {
                settings["symbol"] = Symbol?.Serialize();
            }

            return settings;
        }
    }
}
