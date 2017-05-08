using System;
using System.Collections.Generic;
using System.IO;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SplitterPane class
    /// </summary>
    public partial class SplitterPane 
    {
        public SplitterPane()
        {
        }

        public string MaxSize { get; set; }
        public string MinSize { get; set; }
        public string ContentUrl { get; set; }

        /// <summary>
        /// Specifies HTML attributes for the pane
        /// </summary>
        public IDictionary<string, object> HtmlAttributes
        {
            get;            
        } = new RouteValueDictionary();

        /// <summary>
        /// Specifies the pane contents
        /// </summary>
        public Func<object, object> Template { get; set; }
        public Action TemplateAction { get; set; }
        public string Html { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

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

        public void WriteHtml(TextWriter writer, IKendoHtmlGenerator generator, HtmlEncoder encoder)
        {
            var tag = generator.GenerateTag("div", HtmlAttributes);

            tag.TagRenderMode = TagRenderMode.StartTag;
            tag.WriteTo(writer, encoder);

            tag.AddCssClass("k-pane");

            if (Scrollable.HasValue && Scrollable.Value)
            {
                tag.AddCssClass("k-scrollable");
            }

            if (Html.HasValue())
            {
                writer.Write(Html);
            }
            else if (Template != null)
            {
                writer.WriteContent(Template, encoder);
            }
            else if (TemplateAction != null)
            {
                TemplateAction();
            }

            tag.TagRenderMode = TagRenderMode.EndTag;
            tag.WriteTo(writer, encoder);
        }
    }
}
