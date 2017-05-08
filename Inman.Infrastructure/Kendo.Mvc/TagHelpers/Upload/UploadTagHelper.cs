using Microsoft.AspNetCore.Razor.TagHelpers;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI Upload TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-upload")]
    [RestrictChildren("kendo-upload-async-settings", "kendo-upload-files", "kendo-upload-localization-settings", "kendo-upload-validation-settings")]
    public partial class UploadTagHelper : TagHelperBase
    {
        public UploadTagHelper(IKendoHtmlGenerator generator) : base(generator)
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            context.Items[this.GetType()] = this;
            await output.GetChildContentAsync();
            base.ProcessAsync(context, output);
        }

        protected override void WriteHtml(TagHelperOutput output)
        {
            GenerateId(output);

            var htmlAttributes = new Dictionary<string, object>();
            htmlAttributes.Add("type", "file");

            var tagBuilder = Generator.GenerateTag("input", ViewContext, Id, Name, htmlAttributes);

            output.TagName = "input";
            output.TagMode = TagMode.SelfClosing;
            output.MergeAttributes(tagBuilder);
        }

        protected override string GetInitializationScript()
        {
            var settings = SerializeSettings();

            // TODO: Manually serialized settings go here

            return Initializer.Initialize(Selector, "Upload", settings);
        }
    }
}

