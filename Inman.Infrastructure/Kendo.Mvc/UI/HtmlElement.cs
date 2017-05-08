namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Extensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Html;
    using System.Text.Encodings.Web;

    public class HtmlElement : IHtmlNode
    {
        private readonly TagBuilder tagBuilder;

        public HtmlElement(string tagName)
            : this(tagName, TagRenderMode.Normal)
        { }

        public HtmlElement(string tagName, TagRenderMode renderMode)
        {
            tagBuilder = new TagBuilder(tagName);
            Children = new List<IHtmlNode>();
            RenderMode = renderMode;
        }

        private Action<TextWriter> TemplateCallback
        {
            get;
            set;
        }

        public TagRenderMode RenderMode
        {
            get;
            private set;
        }

        public IList<IHtmlNode> Children
        {
            get;
            private set;
        }

        public IHtmlContentBuilder InnerHtml
        {
            get
            {
                return tagBuilder.InnerHtml;
            }
        }

        public string TagName
        {
            get
            {
                return tagBuilder.TagName;
            }
        }

        public IHtmlNode AddClass(params string[] classes)
        {
            foreach (string @class in classes)
            {
                string value;
                if (Attributes().TryGetValue("class", out value))
                {
                    Attributes()["class"] = value + " " + @class;
                }
                else
                {
                    Attributes()["class"] = @class;
                }
            }

            return this;
        }

        public IHtmlNode AppendTo(IHtmlNode parent)
        {
            parent.Children.Add(this);

            return this;
        }

        public string Attribute(string key)
        {
            return Attributes()[key];
        }

        public IHtmlNode Attribute(string key, string value)
        {
            return Attribute(key, value, true);
        }

        public IHtmlNode Attribute(string key, string value, bool replaceExisting)
        {
            tagBuilder.MergeAttribute(key, value, replaceExisting);

            return this;
        }

        public AttributeDictionary Attributes()
        {
            return tagBuilder.Attributes;
        }

        public IHtmlNode Attributes(object attributes)
        {
            Attributes<string, object>(attributes.ToDictionary());

            return this;
        }

        public IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes)
        {
            return Attributes(attributes, true);
        }

        public IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes, bool replaceExisting)
        {
            tagBuilder.MergeAttributes(attributes, replaceExisting);

            return this;
        }

        public IHtmlNode Html(string value)
        {
            Children.Clear();

            Children.Add(new LiteralNode(value));

            return this;
        }

        public IHtmlNode PrependClass(params string[] classes)
        {
            foreach (string @class in classes.Reverse())
            {
                tagBuilder.AddCssClass(@class);
            }

            return this;
        }

        public IHtmlNode RemoveAttribute(string key)
        {
            tagBuilder.Attributes.Remove(key);

            return this;
        }

        public Action<TextWriter> Template()
        {
            return TemplateCallback;
        }

        public IHtmlNode Template(Action<TextWriter> value)
        {
            TemplateCallback = value;

            return this;
        }
        
        public IHtmlNode Text(string value)
        {
            Children.Clear();

            tagBuilder.InnerHtml.SetContent(value);

            return this;
        }

        public IHtmlNode ToggleAttribute(string key, string value, bool condition)
        {
            if (condition)
            {
                Attribute(key, value);
            }

            return this;
        }

        public IHtmlNode ToggleClass(string @class, bool condition)
        {
            if (condition)
            {
                AddClass(@class);
            }

            return this;
        }

        public IHtmlNode Css(string key, string value)
        {
            string style;

            if (Attributes().TryGetValue("style", out style))
            {
                Attributes()["style"] = style + ";" + key + ":" + value;
            }
            else
            {
                Attributes()["style"] = key + ":" + value;
            }

            return this;
        }

        public IHtmlNode ToggleCss(string key, string value, bool condition)
        {
            if (condition)
            {
                Css(key, value);
            }

            return this;
        }

        public void WriteTo(TextWriter output, HtmlEncoder encoder)
        {
            tagBuilder.TagRenderMode = RenderMode != TagRenderMode.SelfClosing ? TagRenderMode.StartTag : TagRenderMode.SelfClosing;
            tagBuilder.WriteTo(output, encoder);

            if (RenderMode != TagRenderMode.SelfClosing)
            {
                if (TemplateCallback != null)
                {
                    TemplateCallback(output);
                }
                else if (Children.Any())
                {
                    Children.Each(child => child.WriteTo(output, encoder));
                }
                else
                {
                    tagBuilder.InnerHtml.WriteTo(output, encoder);
                }

                tagBuilder.TagRenderMode = TagRenderMode.EndTag;
                tagBuilder.WriteTo(output, encoder);
            }
        }
    }
}
