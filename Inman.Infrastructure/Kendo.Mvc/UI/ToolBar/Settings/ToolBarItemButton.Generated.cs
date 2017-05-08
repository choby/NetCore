using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ToolBarItemButton class
    /// </summary>
    public partial class ToolBarItemButton 
    {
        public IDictionary<string,object> HtmlAttributes { get; set; }

        public ClientHandlerDescriptor Click { get; set; }

        public bool? Enable { get; set; }

        public string Group { get; set; }

        public bool? Hidden { get; set; }

        public string Icon { get; set; }

        public string Id { get; set; }

        public string ImageUrl { get; set; }

        public bool? Selected { get; set; }

        public string SpriteCssClass { get; set; }

        public ClientHandlerDescriptor Toggle { get; set; }

        public bool? Togglable { get; set; }

        public string Text { get; set; }

        public string Url { get; set; }

        public ShowIn? ShowText { get; set; }

        public ShowIn? ShowIcon { get; set; }


        public ToolBar ToolBar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (HtmlAttributes?.Any() == true)
            {
                settings["attributes"] = HtmlAttributes;
            }

            if (Click?.HasValue() == true)
            {
                settings["click"] = Click;
            }

            if (Enable.HasValue)
            {
                settings["enable"] = Enable;
            }

            if (Group?.HasValue() == true)
            {
                settings["group"] = Group;
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

            if (Selected.HasValue)
            {
                settings["selected"] = Selected;
            }

            if (SpriteCssClass?.HasValue() == true)
            {
                settings["spriteCssClass"] = SpriteCssClass;
            }

            if (Toggle?.HasValue() == true)
            {
                settings["toggle"] = Toggle;
            }

            if (Togglable.HasValue)
            {
                settings["togglable"] = Togglable;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Url?.HasValue() == true)
            {
                settings["url"] = Url;
            }

            if (ShowText.HasValue)
            {
                settings["showText"] = ShowText?.Serialize();
            }

            if (ShowIcon.HasValue)
            {
                settings["showIcon"] = ShowIcon?.Serialize();
            }

            return settings;
        }
    }
}
