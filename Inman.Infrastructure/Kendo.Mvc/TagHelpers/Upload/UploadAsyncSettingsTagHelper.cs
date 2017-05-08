using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI async TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-upload-async-settings", ParentTag="kendo-upload", TagStructure=TagStructure.WithoutEndTag )]
    [SuppressTagRendering]
    public partial class UploadAsyncSettingsTagHelper : TagHelperChildBase
    {
        public UploadAsyncSettingsTagHelper() : base()
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);
        }

        protected override void AddSelfToParent(TagHelperContext context)
        {
            var parent = typeof(UploadTagHelper);
            if (context.Items.ContainsKey(parent))
            {
                (context.Items[parent] as UploadTagHelper).Async = this;
            }
        }
    }
}

