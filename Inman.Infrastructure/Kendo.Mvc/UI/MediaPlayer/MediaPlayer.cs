using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MediaPlayer component
    /// </summary>
    public partial class MediaPlayer : WidgetBase
    {
        public MediaPlayer(ViewContext viewContext) : base(viewContext)
        {
            this.Media = new MediaPlayerMedia();
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();
            if (Media.Source != null && !string.IsNullOrEmpty(Media.Title))
            {
                settings["media"] = Media.ToJson();
            }
            writer.Write(Initializer.Initialize(Selector, "MediaPlayer", settings));
        }

        public MediaPlayerMedia Media { get; set; }
    }
}

