namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Text.Encodings.Web;
    using Microsoft.AspNetCore.Html;

    public interface IHtmlNode
    {
        string TagName
        {
            get;
        }

        IHtmlContentBuilder InnerHtml
        {
            get;
        }

        TagRenderMode RenderMode
        {
            get;
        }

        IList<IHtmlNode> Children
        {
            get;
        }

        AttributeDictionary Attributes();

        string Attribute(string key);

        IHtmlNode Attribute(string key, string value);

        IHtmlNode Attribute(string key, string value, bool replaceExisting);

        IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes);

        IHtmlNode Attributes(object attributes);

        IHtmlNode Attributes<TKey, TValue>(IDictionary<TKey, TValue> attributes, bool replaceExisting);

        IHtmlNode AddClass(params string[] classes);

        IHtmlNode PrependClass(params string[] classes);

        IHtmlNode RemoveAttribute(string key);

        IHtmlNode ToggleClass(string @class, bool condition);

        IHtmlNode ToggleAttribute(string key, string value, bool condition);

        IHtmlNode ToggleCss(string key, string value, bool condition);

        IHtmlNode Template(Action<TextWriter> value);

        IHtmlNode Css(string key, string value);

        Action<TextWriter> Template();

        IHtmlNode Html(string value);

        IHtmlNode Text(string value);

        void WriteTo(TextWriter output, HtmlEncoder encoder);

        IHtmlNode AppendTo(IHtmlNode parent);
    }
}
