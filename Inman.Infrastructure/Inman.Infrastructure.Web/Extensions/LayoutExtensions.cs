using System.Web.Mvc;
using Inman.Infrastructure.IOC;

namespace Inman.Infrastructure.Web
{
    public static class LayoutExtensions
    {
        public static void AddTitleParts(this HtmlHelper html, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            pageTitleBuilder.AddTitleParts(parts);
        }

        public static void AppendTitleParts(this HtmlHelper html, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            pageTitleBuilder.AppendTitleParts(parts);
        }

        public static MvcHtmlString Title(this HtmlHelper html, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            html.AppendTitleParts(parts);
            return MvcHtmlString.Create(html.Encode(pageTitleBuilder.GenerateTitle()));
        }

        public static void AddScriptParts(this HtmlHelper html, params string[] parts)
        {
            AddScriptParts(html, ResourceLocation.Head, parts);
        }

        public static void AddScriptParts(this HtmlHelper html, ResourceLocation location, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            pageTitleBuilder.AddScriptParts(location, parts);
        }

        public static void AppendScriptParts(this HtmlHelper html, params string[] parts)
        {
            AppendScriptParts(html, ResourceLocation.Head, parts);
        }

        public static void AppendScriptParts(this HtmlHelper html, ResourceLocation location, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            pageTitleBuilder.AppendScriptParts(location, parts);
        }

        public static MvcHtmlString Scripts(this HtmlHelper html, UrlHelper urlHelper, params string[] parts)
        {
            return Scripts(html, urlHelper, ResourceLocation.Head, parts);
        }

        public static MvcHtmlString Scripts(this HtmlHelper html, UrlHelper urlHelper, ResourceLocation location, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            html.AppendScriptParts(parts);
            return MvcHtmlString.Create(pageTitleBuilder.GenerateScripts(urlHelper, location));
        }

        public static void AddCssFileParts(this HtmlHelper html, params string[] parts)
        {
            AddCssFileParts(html, ResourceLocation.Head, parts);
        }

        public static void AddCssFileParts(this HtmlHelper html, ResourceLocation location, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            pageTitleBuilder.AddCssFileParts(location, parts);
        }

        public static void AppendCssFileParts(this HtmlHelper html, params string[] parts)
        {
            AppendCssFileParts(html, ResourceLocation.Head, parts);
        }

        public static void AppendCssFileParts(this HtmlHelper html, ResourceLocation location, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            pageTitleBuilder.AppendCssFileParts(location, parts);
        }

        public static MvcHtmlString CssFiles(this HtmlHelper html, UrlHelper urlHelper, params string[] parts)
        {
            return CssFiles(html, urlHelper, ResourceLocation.Head, parts);
        }

        public static MvcHtmlString CssFiles(this HtmlHelper html, UrlHelper urlHelper, ResourceLocation location, params string[] parts)
        {
            var pageTitleBuilder = EngineContext.Current.Resolve<IPageTitleBuilder>();
            html.AppendCssFileParts(parts);
            return MvcHtmlString.Create(pageTitleBuilder.GenerateCssFiles(urlHelper, location));
        }
    }
}
