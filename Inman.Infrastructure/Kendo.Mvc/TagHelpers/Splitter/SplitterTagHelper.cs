using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Kendo.Mvc.UI;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI Splitter TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-splitter")]
    [RestrictChildren("kendo-splitter-pane")]
    public partial class SplitterTagHelper : TagHelperBase
    {
        public SplitterTagHelper(IKendoHtmlGenerator generator) : base(generator)
        {
        }

        /// <summary>
        /// Specifies the orientation in which the splitter panes will be ordered
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public SplitterOrientation? Orientation { get; set; }

        public List<SplitterPaneTagHelper> Panes { get; set; } = new List<SplitterPaneTagHelper>();

        protected override void WriteHtml(TagHelperOutput output)
        {
            //Uncomment this to make sure that id attribute and script are generated
            GenerateId(output);

            var htmlAttributes = new Dictionary<string, object>();
            var tagBuilder = Generator.GenerateTag("div", ViewContext, Id, Name, htmlAttributes);

            output.TagName = "div";
            output.MergeAttributes(tagBuilder);
        }

        protected override string GetInitializationScript()
        {
            var settings = SerializeSettings();
            var panes = Panes.Select(i => i.SerializeSettings());

            if (panes.Any())
            {
                settings["panes"] = panes;
            }
            if (Orientation.HasValue)
            {
                settings["orientation"] = Orientation;
            }

            return Initializer.Initialize(Selector, "Splitter", settings);
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (!context.Items.ContainsKey(typeof(SplitterTagHelper)))
            {
                context.Items.Add(typeof(SplitterTagHelper), new List<SplitterTagHelper>());
            }

            var parents = context.Items[typeof(SplitterTagHelper)] as List<SplitterTagHelper>;
            parents.Add(this);
            var childContent = await output.GetChildContentAsync();
            parents.Remove(this);

            base.Process(context, output);
        }
    }
}

