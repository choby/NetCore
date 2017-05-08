using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Menu component
    /// </summary>
    public partial class Menu : WidgetBase, INavigationItemComponent<MenuItem>
    {
        internal bool isPathHighlighted;
        public Menu(ViewContext viewContext) : base(viewContext)
        {
            Animation = new PopupAnimation();

            Items = new List<MenuItem>();

            CloseOnClick = true;
            HighlightPath = true;
            Orientation = MenuOrientation.Horizontal;
            //SecurityTrimming = new SecurityTrimming();
            //SecurityTrimming.Enabled = false;
        }

        public PopupAnimation Animation { get; private set; }

        public IList<MenuItem> Items { get; private set; }

        public Action<MenuItem> ItemAction { get; set; }

        public bool? HighlightPath { get; set; }

        //public SecurityTrimming SecurityTrimming { get; set; }

        //public INavigationItemAuthorization Authorization { get; private set; }

        public string Direction { get; set; }

        protected override void WriteHtml(TextWriter writer)
        {
            if (Items.Any())
            {
                if (HighlightPath.Value)
                {
                    Items.Each(HighlightSelectedItem);
                }

                INavigationComponentHtmlBuilder<MenuItem> builder = new MenuHtmlBuilder(this);

                IHtmlNode menuTag = builder.Build();

                Items.Each(item => item.WriteItem<Menu, MenuItem>(this, menuTag, builder));

                menuTag.WriteTo(writer, HtmlEncoder);
            }

            base.WriteHtml(writer);
        }

        private void HighlightSelectedItem(MenuItem item)
        {
            if (item.IsCurrent(ViewContext, UrlGenerator))
            {
                isPathHighlighted = true;

                item.Selected = item.Parent != null;

                do
                {
                    if (!item.Selected)
                    {
                        item.HtmlAttributes.AppendInValue("class", " ", "k-state-highlight");
                    }
                    item = item.Parent;
                }
                while (item != null);

                return;
            }
            item.Items.Each(HighlightSelectedItem);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            var animation = Animation.ToJson();
            if (animation.Keys.Any())
            {
                settings["animation"] = animation["animation"];
            }

            if (Orientation.HasValue && Orientation != MenuOrientation.Horizontal)
            {
                settings["orientation"] = Orientation?.Serialize();
            }

            if (Direction.HasValue())
            {
                settings["direction"] = Direction;
            }

            if (OpenOnClick.HasValue && OpenOnClick.Value == true)
            {
                settings["openOnClick"] = true;
            }

            if (CloseOnClick.HasValue && CloseOnClick.Value == false)
            {
                settings["closeOnClick"] = false;
            }

            writer.Write(Initializer.Initialize(Selector, "Menu", settings));
        }
    }
}

