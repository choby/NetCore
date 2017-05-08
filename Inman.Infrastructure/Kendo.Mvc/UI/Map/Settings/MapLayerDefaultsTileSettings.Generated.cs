using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsTileSettings class
    /// </summary>
    public partial class MapLayerDefaultsTileSettings 
    {
        public string UrlTemplate { get; set; }

        public string UrlTemplateId { get; set; }

        public string Attribution { get; set; }

        public string[] Subdomains { get; set; }

        public double? Opacity { get; set; }


        public Map Map { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

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

            if (Attribution?.HasValue() == true)
            {
                settings["attribution"] = Attribution;
            }

            if (Subdomains?.Any() == true)
            {
                settings["subdomains"] = Subdomains;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            return settings;
        }
    }
}
