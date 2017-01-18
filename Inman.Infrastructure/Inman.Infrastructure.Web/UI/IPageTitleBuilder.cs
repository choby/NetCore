using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Inman.Infrastructure.Web
{
    public partial interface IPageTitleBuilder
    {
        void AddTitleParts(params string[] parts);
        void AppendTitleParts(params string[] parts);
        string GenerateTitle();

        //void AddMetaDescriptionParts(params string[] parts);
        //void AppendMetaDescriptionParts(params string[] parts);
        //string GenerateMetaDescription();

        //void AddMetaKeywordParts(params string[] parts);
        //void AppendMetaKeywordParts(params string[] parts);
        //string GenerateMetaKeywords();

        void AddScriptParts(ResourceLocation location, params string[] parts);
        void AppendScriptParts(ResourceLocation location, params string[] parts);
        string GenerateScripts(UrlHelper urlHelper, ResourceLocation location);

        void AddCssFileParts(ResourceLocation location, params string[] parts);
        void AppendCssFileParts(ResourceLocation location, params string[] parts);
        string GenerateCssFiles(UrlHelper urlHelper, ResourceLocation location);


        //void AddCanonicalUrlParts(params string[] parts);
        //void AppendCanonicalUrlParts(params string[] parts);
        //string GenerateCanonicalUrls();

        void AddFileContentParts(params string[] parts);
        string GenerateFileContents(HtmlHelper htmlHelper);
    }
}
