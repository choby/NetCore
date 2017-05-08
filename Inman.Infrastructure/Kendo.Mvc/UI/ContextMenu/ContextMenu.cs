using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kendo.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ContextMenu component
    /// </summary>
    public partial class ContextMenu : WidgetBase, INavigationItemComponent<ContextMenuItem>
    {
        internal bool isPathHighlighted;

        public ContextMenu(ViewContext viewContext)
            : base(viewContext)
        {
            Animation = new PopupAnimation();

            Items = new List<ContextMenuItem>();

            CloseOnClick = true;
            HighlightPath = true;
        }

        public string Direction { get; set; }

        public PopupAnimation Animation { get; private set; }

        public bool? OpenOnClick { get; set; }

        public bool? HighlightPath { get; set; }

        public Action<ContextMenuItem> ItemAction { get; set; }

        public IList<ContextMenuItem> Items { get; private set; }

        protected override void WriteHtml(TextWriter writer)
        {
            if (Items.Any())
            {
                if (HighlightPath.Value)
                {
                    Items.Each(HighlightSelectedItem);
                }

                INavigationComponentHtmlBuilder<ContextMenuItem> builder = new ContextMenuHtmlBuilder(this);

                IHtmlNode menuTag = builder.Build();

                Items.Each(item => item.WriteItem<ContextMenu, ContextMenuItem>(this, menuTag, builder));

                menuTag.WriteTo(writer, HtmlEncoder);
            }
            
            base.WriteHtml(writer);
        }

        private void HighlightSelectedItem(ContextMenuItem item)
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

            if (AlignToAnchor.HasValue && AlignToAnchor.Value == true)
            {
                settings["alignToAnchor"] = true;
            }

            if (Orientation.HasValue && Orientation != ContextMenuOrientation.Vertical)
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

            writer.Write(Initializer.Initialize(Selector, "ContextMenu", settings));
        }
    }
}

