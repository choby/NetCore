using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TabStrip component
    /// </summary>
    public partial class TabStrip : WidgetBase, INavigationItemComponent<TabStripItem>
    {
        internal bool isPathHighlighted;

        public PopupAnimation Animation { get; private set; } = new PopupAnimation();

        public IList<TabStripItem> Items { get; private set; } = new List<TabStripItem>();

        public Action<TabStripItem> ItemAction { get; set; }

        public int? SelectedIndex { get; set; } = -1;

        public bool? HighlightPath { get; set; } = true;

        public TabStrip(ViewContext viewContext) : base(viewContext)
        {

        }

        protected override void WriteHtml(TextWriter writer)
        {
            if (Items.Any())
            {
                TabStripHtmlBuilder builder = new TabStripHtmlBuilder(this);

                int itemIndex = 0;
                bool isPathHighlighted = false;

                IHtmlNode tabStripWrapperTag = builder.TabStripWrapperTag();
                IHtmlNode tabStripTag = builder.TabStripTag();

                //this loop is required because of SelectedIndex feature.
                if (HighlightPath == true)
                {
                    Items.Each(HighlightSelectedItem);
                }

                Items.Each(item =>
                {
                    if (!isPathHighlighted)
                    {
                        if (itemIndex == this.SelectedIndex)
                        {
                            item.Selected = true;
                        }
                        itemIndex++;
                    }

                    WriteItem(item, tabStripTag, builder);
                });

                tabStripTag.AppendTo(tabStripWrapperTag);
                tabStripWrapperTag.WriteTo(writer, HtmlEncoder);
            }
            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            var animation = Animation.ToJson();
            if (animation.Keys.Any())
            {
                settings["animation"] = animation["animation"];
            }

            var urls = Items.Where(item => item.Visible).Select(item =>
            {
                if (item.ContentUrl.HasValue())
                {
                    return WebUtility.UrlDecode(item.ContentUrl);
                }
                else
                {
                    return "";
                }
            });

            if (urls.Any(url => url.HasValue()))
            {
                settings["contentUrls"] = urls;
            }

            writer.Write(Initializer.Initialize(Selector, "TabStrip", settings));
        }


        private void WriteItem(TabStripItem item, IHtmlNode parentTag, TabStripHtmlBuilder builder)
        {
            if (ItemAction != null)
            {
                ItemAction(item);
            }

            if (item.Visible)
            {
                IHtmlNode itemTag = builder.ItemTag(item).AppendTo(parentTag.Children[0]);

                builder.ItemInnerTag(item).AppendTo(itemTag);

                builder.ItemContentTag(item).AppendTo(parentTag);
            }
        }

        private void HighlightSelectedItem(TabStripItem item)
        {
            if (item.IsCurrent(ViewContext, UrlGenerator))
            {
                isPathHighlighted = true;
                item.Selected = true;
            }
        }
    }
}

