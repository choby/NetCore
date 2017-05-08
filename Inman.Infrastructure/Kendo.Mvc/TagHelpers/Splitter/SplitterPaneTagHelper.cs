using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI SplitterPane TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-splitter-pane", ParentTag = "kendo-splitter")]
    public class SplitterPaneTagHelper : TagHelper
    {
        public SplitterPaneTagHelper() : base()
        {
            this.TagName = "div";
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrEmpty(TagName))
            {
                output.TagName = null;
            }
            else
            {
                output.TagName = TagName;
            }
            var parents = context.Items[typeof(SplitterTagHelper)] as List<SplitterTagHelper>;

            if (parents.Count > 0)
            {
                parents[parents.Count - 1].Panes.Add(this);
            }
        }

        public string TagName { get; set; }

        public bool? Collapsed { get; set; }
        public string CollapsedSize { get; set; }
        public bool? Collapsible { get; set; }
        public bool? Resizable { get; set; }
        public bool? Scrollable { get; set; }
        public string Size { get; set; }
        public string MaxSize { get; set; }
        public string MinSize { get; set; }
        public string ContentUrl { get; set; }

        internal Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Collapsed.HasValue)
            {
                settings["collapsed"] = Collapsed;
            }

            if (CollapsedSize?.HasValue() == true)
            {
                settings["collapsedSize"] = CollapsedSize;
            }

            if (Collapsible.HasValue)
            {
                settings["collapsible"] = Collapsible;
            }

            if (Resizable.HasValue)
            {
                settings["resizable"] = Resizable;
            }

            if (Scrollable.HasValue)
            {
                settings["scrollable"] = Scrollable;
            }

            if (Size?.HasValue() == true)
            {
                settings["size"] = Size;
            }

            if (MaxSize?.HasValue() == true)
            {
                settings["max"] = MaxSize;
            }

            if (MinSize?.HasValue() == true)
            {
                settings["min"] = MinSize;
            }

            if (ContentUrl?.HasValue() == true)
            {
                settings["contentUrl"] = ContentUrl;
            }

            return settings;
        }
    }
}
