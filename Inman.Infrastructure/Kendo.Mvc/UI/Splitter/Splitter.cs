using System.IO;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Splitter component
    /// </summary>
    public partial class Splitter : WidgetBase
        
    {
        public Splitter(ViewContext viewContext) : base(viewContext)
        {
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.TagRenderMode = TagRenderMode.StartTag;
            tag.WriteTo(writer, HtmlEncoder);

            tag.AddCssClass("k-widget k-splitter");          
            tag.AddCssClass(Orientation == SplitterOrientation.Horizontal ? "k-splitter-horizontal" : "k-splitter-vertical");

            Panes.Each(p => p.WriteHtml(writer, Generator, HtmlEncoder));

            tag.TagRenderMode = TagRenderMode.EndTag;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            // TODO: Manually serialized settings go here

            writer.Write(Initializer.Initialize(Selector, "Splitter", settings));
        }
    }
}

