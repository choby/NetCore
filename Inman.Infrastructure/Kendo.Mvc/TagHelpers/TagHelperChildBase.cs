using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Kendo.Mvc.TagHelpers
{
    public abstract class TagHelperChildBase : TagHelper
    {
        protected TagHelperChildBase()
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            AddSelfToParent(context);

            if (SuppressTagRendering())
            {
                output.SuppressOutput();
            }

            await output.GetChildContentAsync();
        }

        protected abstract void AddSelfToParent(TagHelperContext context);
        private bool SuppressTagRendering()
        {
            return GetType().GetTypeInfo().GetCustomAttributes(true).Any(p => p.GetType() == typeof(SuppressTagRenderingAttribute));
        }
    }
}
