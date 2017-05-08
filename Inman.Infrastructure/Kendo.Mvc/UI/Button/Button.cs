using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Button component
    /// </summary>
    public partial class Button : WidgetBase
        
    {
		public string Html { get; set; }

		public Func<object, object> Content { get; set; }

		public Action ContentAction { get; set; }

		public string Tag { get; set; }

		public Button(ViewContext viewContext) : base(viewContext)
        {
			Enable = true;
			Tag = "button";
		}

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag(Tag, ViewContext, Id, Name, HtmlAttributes);

            tag.TagRenderMode = TagRenderMode.StartTag;
            tag.WriteTo(writer, HtmlEncoder);

			if (Html.HasValue())
			{
				writer.Write(Html);
			}
			else if (Content != null)
			{
				writer.WriteContent(Content, HtmlEncoder);
			}
			else if (ContentAction != null)
			{
				ContentAction();
			}

            tag.TagRenderMode = TagRenderMode.EndTag;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			if (Enable.Value == true)
			{
				settings.Remove("enable");
			}

            writer.Write(Initializer.Initialize(Selector, "Button", settings));
        }
    }
}

