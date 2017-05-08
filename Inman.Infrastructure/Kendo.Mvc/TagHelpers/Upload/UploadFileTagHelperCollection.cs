using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using Kendo.Mvc.Rendering;
using System.Threading.Tasks;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI UploadFile TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-upload-files", ParentTag="kendo-upload")]
    [RestrictChildren("kendo-upload-file")]
    [SuppressTagRendering]
    public partial class UploadFilesTagHelper : TagHelperCollectionBase<UploadFileTagHelper>
    {
        public IList<UploadFileTagHelper> Files
        {
            get
            {
                return InternalRef;
            }
        }
        public UploadFilesTagHelper() : base(new List<UploadFileTagHelper>())
        {

        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            context.Items[this.GetType()] = this;
            var child = await output.GetChildContentAsync();
            await base.ProcessAsync(context, output);
        }

        protected override void AddSelfToParent(TagHelperContext context)
        {
            var parent = typeof(UploadTagHelper);
            if (context.Items.ContainsKey(parent))
            {
                (context.Items[parent] as UploadTagHelper).Files = this;
            }
        }
    }
}
