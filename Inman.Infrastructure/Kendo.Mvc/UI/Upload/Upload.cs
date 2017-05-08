using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Upload component
    /// </summary>
    public partial class Upload : WidgetBase
        
    {
		public bool? Enabled { get; set; }

		public UploadMessagesSettings Messages { get; } = new UploadMessagesSettings();

		public Upload(ViewContext viewContext) : base(viewContext)
        {
			Async.ViewContext = ViewContext;
			Async.UrlGenerator = UrlGenerator;
			Async.UrlDecoder = (string url) => IsSelfInitialized ? WebUtility.UrlDecode(url) : url;
		}

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("input", ViewContext, Id, Name, HtmlAttributes);

			tag.MergeAttribute("type", "file");

            tag.TagRenderMode = TagRenderMode.SelfClosing;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			var messages = Messages.Serialize();
			if (messages.Any())
			{
				settings["localization"] = messages;
			}

			if (Enabled.HasValue)
			{
				settings["enabled"] = Enabled;
			}

			writer.Write(Initializer.Initialize(Selector, "Upload", settings));
        }
    }
}

