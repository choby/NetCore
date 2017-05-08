using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapMarker class
    /// </summary>
    public partial class MapMarker : MapBaseLayerSettings, IMapMarkersShapeSettings
    {
        public IDictionary<string, object> HtmlAttributes
        {
            get;
            private set;
        } = new Dictionary<string, object>();

        public string ShapeName { get; set; }

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

            if (HtmlAttributes.Any())
            {
                settings["attributes"] = HtmlAttributes;
            }
            
            SerializeTooltip(settings);
            this.SerializeShape(settings);

            return settings;
        }
    }
}
