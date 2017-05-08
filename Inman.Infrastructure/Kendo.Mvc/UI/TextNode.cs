using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;

namespace Kendo.Mvc.UI
{
    public class TextNode : IHtmlNode
    {
        public TextNode(string content)
        {
            this.Content = new StringHtmlContent(content);
        }

        public IHtmlContent Content { get; set; }

        public IList<IHtmlNode> Children
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IHtmlContentBuilder InnerHtml
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public TagRenderMode RenderMode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string TagName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IHtmlNode AddClass(params string[] classes)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode AppendTo(IHtmlNode parent)
        {
            parent.Children.Add(this);

            return this;
        }

        public string Attribute(string key)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Attribute(string key, string value)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Attribute(string key, string value, bool replaceExisting)
        {
            throw new NotImplementedException();
        }

        public AttributeDictionary Attributes()
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Attributes(object attributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes, bool replaceExisting)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Css(string key, string value)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Html(string value)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode PrependClass(params string[] classes)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode RemoveAttribute(string key)
        {
            throw new NotImplementedException();
        }

        public Action<TextWriter> Template()
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Template(Action<TextWriter> value)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode Text(string value)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode ToggleAttribute(string key, string value, bool condition)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode ToggleClass(string @class, bool condition)
        {
            throw new NotImplementedException();
        }

        public IHtmlNode ToggleCss(string key, string value, bool condition)
        {
            throw new NotImplementedException();
        }

        public void WriteTo(TextWriter output, HtmlEncoder encoder)
        {
            this.Content.WriteTo(output, encoder);
        }
    }
}
