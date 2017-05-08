using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ToolBarItemMenuButton class
    /// </summary>
    public partial class ToolBarItemMenuButton 
    {
        public IDictionary<string,object> HtmlAttributes { get; set; }

        public bool? Enable { get; set; }

        public bool? Hidden { get; set; }

        public string Icon { get; set; }

        public string Id { get; set; }

        public string ImageUrl { get; set; }

        public string SpriteCssClass { get; set; }

        public string Text { get; set; }

        public string Url { get; set; }


        public ToolBar ToolBar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (HtmlAttributes?.Any() == true)
            {
                settings["attributes"] = HtmlAttributes;
            }

            if (Enable.HasValue)
            {
                settings["enable"] = Enable;
            }

            if (Hidden.HasValue)
            {
                settings["hidden"] = Hidden;
            }

            if (Icon?.HasValue() == true)
            {
                settings["icon"] = Icon;
            }

            if (Id?.HasValue() == true)
            {
                settings["id"] = Id;
            }

            if (ImageUrl?.HasValue() == true)
            {
                settings["imageUrl"] = ImageUrl;
            }

            if (SpriteCssClass?.HasValue() == true)
            {
                settings["spriteCssClass"] = SpriteCssClass;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Url?.HasValue() == true)
            {
                settings["url"] = Url;
            }

            return settings;
        }
    }
}
