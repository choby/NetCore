using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ToolBarItem class
    /// </summary>
    public partial class ToolBarItem 
    {
        public IDictionary<string,object> HtmlAttributes { get; set; }

        public List<ToolBarItemButton> Buttons { get; set; } = new List<ToolBarItemButton>();

        public ClientHandlerDescriptor Click { get; set; }

        public bool? Enable { get; set; }

        public string Group { get; set; }

        public bool? Hidden { get; set; }

        public string Icon { get; set; }

        public string Id { get; set; }

        public string ImageUrl { get; set; }

        public List<ToolBarItemMenuButton> MenuButtons { get; set; } = new List<ToolBarItemMenuButton>();

        public string OverflowTemplate { get; set; }

        public string OverflowTemplateId { get; set; }

        public bool? Primary { get; set; }

        public bool? Selected { get; set; }

        public string SpriteCssClass { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public string Text { get; set; }

        public bool? Togglable { get; set; }

        public ClientHandlerDescriptor Toggle { get; set; }

        public string Url { get; set; }

        public CommandType? Type { get; set; }

        public ShowIn? ShowText { get; set; }

        public ShowIn? ShowIcon { get; set; }

        public ShowInOverflowPopup? Overflow { get; set; }


        public ToolBar ToolBar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (HtmlAttributes?.Any() == true)
            {
                settings["attributes"] = HtmlAttributes;
            }

            var buttons = Buttons.Select(i => i.Serialize());
            if (buttons.Any())
            {
                settings["buttons"] = buttons;
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

            var menuButtons = MenuButtons.Select(i => i.Serialize());
            if (menuButtons.Any())
            {
                settings["menuButtons"] = menuButtons;
            }

            if (OverflowTemplateId.HasValue())
            {
                settings["overflowTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", ToolBar.IdPrefix, OverflowTemplateId
                    )
                };
            }
            else if (OverflowTemplate.HasValue())
            {
                settings["overflowTemplate"] = OverflowTemplate;
            }

            if (Primary.HasValue)
            {
                settings["primary"] = Primary;
            }

            if (Selected.HasValue)
            {
                settings["selected"] = Selected;
            }

            if (SpriteCssClass?.HasValue() == true)
            {
                settings["spriteCssClass"] = SpriteCssClass;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", ToolBar.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Togglable.HasValue)
            {
                settings["togglable"] = Togglable;
            }

            if (Toggle?.HasValue() == true)
            {
                settings["toggle"] = Toggle;
            }

            if (Url?.HasValue() == true)
            {
                settings["url"] = Url;
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            if (ShowText.HasValue)
            {
                settings["showText"] = ShowText?.Serialize();
            }

            if (ShowIcon.HasValue)
            {
                settings["showIcon"] = ShowIcon?.Serialize();
            }

            if (Overflow.HasValue)
            {
                settings["overflow"] = Overflow?.Serialize();
            }

            return settings;
        }
    }
}
