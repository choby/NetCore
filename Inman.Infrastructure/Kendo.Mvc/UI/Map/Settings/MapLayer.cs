using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayer class
    /// </summary>
    public partial class MapLayer : MapBaseLayerSettings, IMapMarkersShapeSettings
    {
        public DataSource DataSource { get; set; }

        public string ShapeName { get; set; }

        public string SymbolName { get; set; }

        public ClientHandlerDescriptor SymbolHandler { get; set; }

        protected override ViewContext ViewContext
        {
            get
            {
                return Map?.ViewContext;
            }
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (DataSource != null)
            {
                settings["dataSource"] = DataSource.ToJson();
            }

            if (SymbolHandler != null)
            {
                settings["symbol"] = SymbolHandler;
            }
            else if (SymbolName.HasValue())
            {
                settings["symbol"] = SymbolName;
            }
            else if (Symbol.HasValue)
            {
                settings["symbol"] = Symbol.ToString().ToLowerInvariant();
            }

            SerializeTooltip(settings);
            this.SerializeShape(settings);

            return settings;
        }
    }
}
