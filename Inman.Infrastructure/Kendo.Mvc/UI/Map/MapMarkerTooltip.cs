using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    public class MapMarkerTooltip : Tooltip
    {
        public MapMarkerTooltip(ViewContext viewContext)
            : base(viewContext)
        {
        }

        public string Template { get; set; }

        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            return settings;
        }
    }
}
